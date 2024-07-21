using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509;
using Revit.Entity.Commons;
using Revit.Entity.Family;
using Revit.Entity.Permissions;
using Revit.Entity.Project;
using Revit.Entity.Users;
using Revit.Repository;
using Revit.Service.Commons;
using Revit.Service.Extension;
using Revit.Service.Permissions;
using Snowflake.Core;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.IO.Pipelines;
using System.Net;

namespace Revit.Service.Families
{
    public class FamilyService : BaseService, IFamilyService
    {
        private readonly IBaseRepository<R_Family> _familiesRepository;
        private readonly IBaseRepository<R_FamilyCategory> _familyCategoryRepository;
        private readonly IStorageClient _localStorage;
        private readonly IMapper _mapper;
        private readonly IdWorker _idWorker;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<R_User> _userManager;

        public FamilyService(IBaseRepository<R_Family> familiesRepository,IBaseRepository<R_FamilyCategory> familyCategoryRepository, IMapper mapper, IdWorker idWorker,
        IEnumerable<IStorageClient> storageClients, IHttpContextAccessor httpContextAccessor
            , UserManager<R_User> userManager) : base(mapper)
        {
            this._mapper = mapper;
            this._idWorker = idWorker;
            this._httpContextAccessor = httpContextAccessor;
            this._userManager = userManager;
            this._familiesRepository = familiesRepository;
            this._familyCategoryRepository = familyCategoryRepository;
            this._localStorage = storageClients.First(c => c.StorageType == StorageType.Public);
        }




        public async Task<IEnumerable<FamilyDto>> GetFamiliesByUser(long userId)
        {
            var query = _familiesRepository.GetList(x => x.CreatorId == userId);
            var results = _mapper.Map<IEnumerable<FamilyDto>>(query);
            return results;
        }

        public async Task<PagedList<FamilyDto>> GetListAsync(PageRequestDto parameters)
        {
            PagedList<FamilyDto> pageList = new PagedList<FamilyDto>() { PageIndex = parameters.PageIndex, PageSize = parameters.PageSize };
            var query = _familiesRepository.GetList(x => string.IsNullOrWhiteSpace(parameters.SearchMessage) || x.Name.Contains(parameters.SearchMessage)).AsQueryable();
            var result = _familiesRepository.GetPagedList(parameters.PageIndex * parameters.PageSize, parameters.PageSize, query);
            if (result.Any())
            {
                var dtos = _mapper.Map<IEnumerable<FamilyDto>>(result);
                foreach (var item in dtos)
                {
                    if (item.MainPhotoUrl == null)
                    {
                        continue;
                    }
                    var user = await R_User.GetCurrentUser(_httpContextAccessor, _userManager);
                    item.Creator = _mapper.Map<UserDto>(user);
                    item.CategoriesIds = _familyCategoryRepository.GetList(x => x.FamilyId.Equals(item.Id)).Select(x=>x.CategoryId);
                    if (File.Exists(item.MainPhotoUrl.LocalPath))
                    {
                        using (FileStream fs = new FileStream(item.MainPhotoUrl.LocalPath, FileMode.Open, FileAccess.Read))
                        {
                            byte[] byteArray = new byte[fs.Length];
                            await fs.ReadAsync(byteArray, 0, byteArray.Length);
                            item.MainPhotoBytes = byteArray;
                        }
                    }
                }
                pageList.Items = dtos.ToList();
            }
            return pageList;
        }

        //将保存代码替换成storege的详细实现
        public async Task<IEnumerable<FamilyDto>> UploadFiles(FamilyUploadDto filesDto)
        {
            var results = new List<FamilyDto>();
            var familyFile = filesDto.Files.FirstOrDefault();
            var image = filesDto.Files.LastOrDefault();
            if (familyFile != null)
            {
                var versionNumber = "1";
                var sameFileKey = _idWorker.NextId();
                string familyUri = Path.Combine(sameFileKey.ToString(), versionNumber, familyFile.FileName);
                var familyUrl = await _localStorage.SaveAsync(familyUri, familyFile.OpenReadStream());
                var imageUri = familyUri.Replace("rfa", "jpg");
                var imageUrl = await _localStorage.SaveAsync(imageUri, image.OpenReadStream());

                if (File.Exists(imageUrl.LocalPath) && File.Exists(familyUrl.LocalPath))
                {
                    var r_Family = R_Family.Create(_idWorker.NextId(), sameFileKey, familyFile.Length, familyFile.FileName, HashHelper.ComputeSha256Hash(familyFile.OpenReadStream()), familyUrl, imageUrl);
                    var result = _familiesRepository.Add(r_Family);
                    if (result != null)
                    {
                        var dto = _mapper.Map<FamilyDto>(result);
                        if (dto != null)
                        {
                            results.Add(dto);
                        }
                    }
                    else
                    {
                        throw new Exception("上传失败");
                    }
                }
            }
            return results;
        }


        public async Task<byte[]> DownloadFamily(long familyId)
        {
            var file = _familiesRepository.Get(familyId);
            if (file == null) throw new Exception("请求文件不存在");
            if (File.Exists(file.SaveUrl.AbsolutePath))
            {
                using (FileStream fs = new FileStream(file.SaveUrl.AbsolutePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] byteArray = new byte[fs.Length];
                    fs.Read(byteArray, 0, byteArray.Length);
                    return byteArray;
                }
            }
            return null;
        }

        public async Task<FamilyDto> AuditingFamily(long familyId, FamilyPutDto familyPutDto)
        {
            if (familyPutDto==null||!familyPutDto.CategoriesIds.Any())
            {
                throw new Exception("this put data is not vaild");
            }
            var file = _familiesRepository.Get(familyId);
            if (file == null) throw new Exception("this file is not exist");
            var rFamily = _mapper.Map(familyPutDto, file);
            var familyCount = _familiesRepository.Update(rFamily);
            var familyCategories = familyPutDto.CategoriesIds.Select<long, R_FamilyCategory>(x => new R_FamilyCategory() { FamilyId = familyId, CategoryId = x }).ToList();
            var familyCategoriesCount = _familyCategoryRepository.AddRange(familyCategories);
            if (familyCount < 0|| familyCategoriesCount!= familyCategories.Count) { throw new Exception("this update for famiy is not success"); }
            var familyDto = _mapper.Map<FamilyDto>(rFamily);
            return familyDto;
        }
    }
}

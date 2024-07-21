using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509;
using Revit.Entity.Commons;
using Revit.Entity.Entity.Dtos.Family;
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
    public class CategoryService : BaseService, ICategoryService
    {
        private readonly IBaseRepository<R_Category> _categoriesRepository;
        private readonly IStorageClient localStorage;
        private readonly IdWorker idWorker;

        public CategoryService(IBaseRepository<R_Category> categoriesRepository, IMapper mapper, IdWorker idWorker) : base(mapper)
        {
            this._categoriesRepository = categoriesRepository;
            this.idWorker = idWorker;
        }

        public async Task<CategoryDto> AddCategory(CategoryCreateDto createMessages)
        {
            var rCategory = _mapper.Map<R_Category>(createMessages);
            rCategory.Id = this.idWorker.NextId();
            _categoriesRepository.Add(rCategory);
            var result = _mapper.Map<CategoryDto>(rCategory);
            return result;
        }

        public async Task<IEnumerable<CategoryDto>> GetCategories()
        {
            var results = _categoriesRepository.GetList(x => true).ToList();
            var dtos = _mapper.Map<List<CategoryDto>>(results);
            return dtos;
        }
    }
}

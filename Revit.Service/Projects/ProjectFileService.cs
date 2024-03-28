using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Revit.Entity.Project;
using Revit.Entity.Users;
using Revit.Repository;
using Revit.Service.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.Projects
{
    public class ProjectFileService : BaseService, IProjectFileService
    {


        private readonly IBaseRepository<R_Project> projectRepository;
        private readonly IBaseRepository<R_User> userRepository;
        private readonly IBaseRepository<R_ProjectUser> projectUserRepository;
        private readonly IBaseRepository<R_ProjectFolder> projectFolderRepository;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly UserManager<R_User> userManager;

        public ProjectFileService(IBaseRepository<R_Project> projectRepository
            , IBaseRepository<R_User> usertRepository, IBaseRepository<R_ProjectUser> projectUserRepository
            , IBaseRepository<R_ProjectFolder> projectFolderRepository
            , IMapper mapper, IConfiguration configuration, UserManager<R_User> userManager) : base(mapper)
        {
            this.projectRepository = projectRepository;
            this.userRepository = usertRepository;
            this.projectUserRepository = projectUserRepository;
            this.projectFolderRepository = projectFolderRepository;
            this.mapper = mapper;
            this.configuration = configuration;
            this.userManager = userManager;
        }


        public async Task<IEnumerable<ProjectFolderDto>> UploadProjectFile(long folderId,long userId, ProjectUploadFileDto projectUploadFileDto)
        {
            var folder = projectFolderRepository.Get(folderId);
            if (folder == null)
            {
                return null;
            }
            var results = new List<ProjectFolderDto>();
            foreach (var file in projectUploadFileDto.Files)
            {
                var newFile = new R_ProjectFolder()
                {
                    RelativePath = Path.Combine(folder.RelativePath, file.FileName),
                    ProjectId = folder.ProjectId,
                    Name = Path.GetFileNameWithoutExtension(file.FileName),
                    FileExtension = Path.GetExtension(file.FileName).Trim('.'),
                    FileSize = ConvertFileSize(file.Length), 
                    CreatorId = userId
                };
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Base", folder.ProjectId.ToString(), folder.RelativePath);
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                using (var stream = new FileStream(Path.Combine(filePath,file.FileName), FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                var result=projectFolderRepository.Add(newFile);
                if (result!=null)
                {
                    var projectFolderDto = mapper.Map<ProjectFolderDto>(result);
                    var user = userRepository.Get(userId);
                    projectFolderDto.CreatorName = user?.FullName ?? "未知用户";
                    results.Add(projectFolderDto);
                }
                else
                {
                    throw new Exception("上传失败");
                }
            }
            return results;
        }



        public string ConvertFileSize(long fileSize)
        {
            const long KB = 1024;
            const long MB = KB * 1024;
            const long GB = MB * 1024;

            if (fileSize < KB)
                return $"{fileSize} B";
            else if (fileSize < MB)
                return $"{Math.Round(d: fileSize / KB, 2)} KB";
            else if (fileSize < GB)
                return $"{Math.Round(d: fileSize / MB, 2)} MB";
            else
                return $"{Math.Round(d: fileSize / GB, 2)} GB";
        }

    }
}

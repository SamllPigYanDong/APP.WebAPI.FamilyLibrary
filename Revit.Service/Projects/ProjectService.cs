using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Revit.Entity.Accounts;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Entity.Users;
using Revit.EntityFrameworkCore;
using Revit.Repository;
using Revit.Service.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Revit.Service.Projects
{
    public class ProjectService : BaseService, IProjectService
    {
        private readonly IBaseRepository<R_Project> projectRepository;
        private readonly IBaseRepository<R_User> userRepository;
        private readonly IBaseRepository<R_ProjectUser> projectUserRepository;
        private readonly IBaseRepository<R_ProjectFolder> projectFolderRepository;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public ProjectService(IBaseRepository<R_Project> projectRepository
            , IBaseRepository<R_User> usertRepository, IBaseRepository<R_ProjectUser> projectUserRepository
            , IBaseRepository<R_ProjectFolder> projectFolderRepository
            , IMapper mapper, IConfiguration configuration) : base(mapper)
        {
            this.projectRepository = projectRepository;
            this.userRepository = usertRepository;
            this.projectUserRepository = projectUserRepository;
            this.projectFolderRepository = projectFolderRepository;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        /// <summary>
        /// 获取查询条件下的项目
        /// </summary>
        /// <param name="projectRequestDto"></param>
        /// <returns></returns>
        public IEnumerable<ProjectResponseDto> GetProjects(ProjectRequestDto projectRequestDto)
        {
            Expression<Func<R_Project, bool>> predicate = x =>
            string.IsNullOrWhiteSpace(projectRequestDto.SearchMessage)
                || x.ProjectName.Contains(projectRequestDto.SearchMessage);
            var projects = projectRepository.GetList(predicate)
                .Skip((projectRequestDto.PageIndex - 1) * projectRequestDto.PageSize)
                .Take(projectRequestDto.PageSize);
            var results = mapper.Map<List<ProjectResponseDto>>(projects);
            foreach (var project in results)
            {
                var user = userRepository.Get(project.CreatorId);
                var userDto = mapper.Map<AccountDto>(user);
                project.UserDto = userDto;
                var userIds = projectUserRepository.GetList(x => x.ProjectId == project.Id).Select(x => x.UserId);
                var projectSUsers = userRepository.GetList(x => userIds.Contains(x.Id));
                var projectSUsersDto = mapper.Map<List<AccountDto>>(projectSUsers);
                project.ProjectUserCount = projectSUsersDto.Count;
            }
            return results;
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        public async Task<ProjectResponseDto> CreateProject(ProjectCreateDto createDto)
        {
            R_Project project = mapper.Map<R_Project>(createDto); ;
            //// 保存图标在项目文档基础路径下
            //if (createDto.Icon != null && createDto.Icon.Length > 0)
            //{
            //    // 定义文件保存的路径
            //    var basePath = configuration.GetValue<string>(Appsettings.FileSaveBasePath);
            //    var path = Path.Combine(project.BasePath, "images", createDto.Icon.FileName);
            //    var directoryInfo = new DirectoryInfo(Path.GetDirectoryName(path));
            //    if (!directoryInfo.Exists)
            //        directoryInfo.Create();
            //    using (var stream = new FileStream(path, FileMode.CreateNew))
            //    {
            //        await createDto.Icon.CopyToAsync(stream);
            //    }
            //    project.IconPath = path;
            //}
            var result = projectRepository.Add(project);
            var creator = userRepository.Get(createDto.CreatorId);
            var accountDto = mapper.Map<AccountDto>(creator);
            if (result != null)
            {
                //创建项目存储根目录
                CreateProjectRootPath(result);

                //传回结果
                var projectDto = mapper.Map<ProjectResponseDto>(result);
                projectDto.UserDto = accountDto;
                projectDto.ProjectUserCount = 1;
                projectDto.DocumentsSize = 0;

                return projectDto;
            }
            return null;
        }

        private bool CreateProjectRootPath(R_Project createDto)
        {
            // 定义文件保存的路径
            var project = mapper.Map<R_Project>(createDto);
            var basePath = @$"{Directory.GetCurrentDirectory()}/{configuration.GetValue<string>(Appsettings.FileSaveBasePath)}";
            var baseFolder = new R_ProjectFolder()
            {
                CreationTime = DateTime.Now,
                Name = "RootPath",
                RelativePath = $"",
                CreatorId = createDto.CreatorId,
                ProjectId = project.Id,
                LastModificationTime = DateTime.Now,
            };
            projectFolderRepository.Add(baseFolder);

            var projectBaseFolder = new R_ProjectFolder()
            {
                CreationTime = DateTime.Now,
                Name = "ProjectRootPath",
                RelativePath = @"ProjectRootPath",
                CreatorId = createDto.CreatorId,
                ProjectId = project.Id,
                LastModificationTime = DateTime.Now,
            };
            projectFolderRepository.Add(projectBaseFolder);
            return true;
        }

        /// <summary>
        /// 获取项目内的用户
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public IEnumerable<UserDto> GetProjectUsers(long projectId)
        {
            var users = (from projectUser in projectUserRepository.GetQueryable()
                         where projectUser.ProjectId == projectId
                         join user in userRepository.GetQueryable() on projectUser.UserId equals user.Id
                         select user).ToList();
            var results = mapper.Map<List<UserDto>>(users);
            return results;
        }

        /// <summary>
        /// 删除指定项目
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public int DeleteProject(long projectId)
        {
            return projectRepository.Delete(x => x.Id == projectId);
        }

        /// <summary>
        /// 获取项目的文档
        /// </summary>
        /// <param name="projectGetFileDto"></param>
        /// <returns></returns>
        public List<ProjectFolderDto> GetProjectPathFolders(ProjectGetFoldersDto projectGetFileDto)
        {

            var project = projectRepository.Get(projectGetFileDto.ProjectId);
            if (project == null) return null;
            var folderModels = projectFolderRepository.GetQueryable().Where(x => x.ProjectId == project.Id && x.RelativePath.Contains(projectGetFileDto.RequestPath));

            var results = mapper.Map<List<ProjectFolderDto>>(folderModels);
            foreach (var result in results)
            {
                var user = userRepository.Get(result.CreatorId);
                if (user!=null)
                {
                    result.CreatorName = user.UserName??"未知用户";
                }
            }
            return results;
        }


        /// <summary>
        /// 创建项目中的文档
        /// </summary>
        /// <param name="createFolderDto"></param>
        /// <returns></returns>
        public ProjectFolderDto CreateProjectFolder(ProjectCreateFolderDto createFolderDto)
        {
            var hasParentFolder = projectFolderRepository.GetQueryable()
                .Any(x => x.ProjectId == createFolderDto.ProjectId && x.RelativePath.Contains(createFolderDto.RequestPath));
            var hasFolder = projectFolderRepository.GetQueryable()
               .Any(x => x.ProjectId == createFolderDto.ProjectId && x.RelativePath.Contains(Path.Combine(createFolderDto.RequestPath, createFolderDto.FolderName)));
            if (hasParentFolder&&! hasFolder)
            {
                var newFolder = new R_ProjectFolder()
                {
                    CreationTime = DateTime.Now,
                    LastModificationTime = DateTime.Now,
                    Name = createFolderDto.FolderName,
                    RelativePath = Path.Combine(createFolderDto.RequestPath, createFolderDto.FolderName),
                    CreatorId = createFolderDto.CreatorId,
                    ProjectId = createFolderDto.ProjectId
                };
                var result=projectFolderRepository.Add(newFolder);
                var projectFolderDto=mapper.Map<ProjectFolderDto>(result);
                return projectFolderDto;
            }
            return null;
        }


    }
}

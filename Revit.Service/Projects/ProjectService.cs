using AutoMapper;
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

namespace Revit.Service.Projects
{
    public class ProjectService : BaseService, IProjectService
    {
        private readonly IBaseRepository<R_Project> projectRepository;
        private readonly IBaseRepository<R_User> userRepository;
        private readonly IBaseRepository<R_ProjectUser> projectUserRepository;
        private readonly IMapper mapper;

        public ProjectService(IBaseRepository<R_Project> projectRepository
            , IBaseRepository<R_User> usertRepository, IBaseRepository<R_ProjectUser> projectUserRepository
            , IMapper mapper) : base(mapper)
        {
            this.projectRepository = projectRepository;
            this.userRepository = usertRepository;
            this.projectUserRepository = projectUserRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ProjectResponseDto> GetProjects(ProjectRequestDto projectRequestDto)
        {
            Expression<Func<R_Project, bool>> predicate = x =>
            string.IsNullOrWhiteSpace(projectRequestDto.SearchMessage)
                || x.ProjectName.Contains(projectRequestDto.SearchMessage);
            var items = projectRepository.GetList(predicate);
            var results = mapper.Map<List<ProjectResponseDto>>(items);
            return results;
        }

        public IEnumerable<UserDto> GetProjectUsers(long projectId)
        {
            var users = (from projectUser in projectUserRepository.GetQueryable()
                         where projectUser.ProjectId == projectId
                         join user in userRepository.GetQueryable() on projectUser.UserId equals user.Id
                         select user).ToList();
            var results = mapper.Map<List<UserDto>>(users);
            return results;
        }





    }
}

using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Entity.Users;
using System.Linq.Expressions;

namespace Revit.Service.Projects
{
    public interface IProjectService
    {
        IEnumerable<ProjectResponseDto> GetProjects(ProjectRequestDto pridicate);
        IEnumerable<UserDto> GetProjectUsers(long request);
    }
}
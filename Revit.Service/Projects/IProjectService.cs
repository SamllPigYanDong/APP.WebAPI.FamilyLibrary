using Revit.Entity.Project;
using Revit.Entity.Users;

namespace Revit.Service.Projects
{
    public interface IProjectService
    {
        Task<ProjectResponseDto> CreateProject(ProjectCreateDto createDto);
        int DeleteProject(long projectId);
        IEnumerable<ProjectResponseDto> GetProjects(ProjectRequestDto projectRequestDto);
        IEnumerable<UserDto> GetProjectUsers(long projectId);
    }
}
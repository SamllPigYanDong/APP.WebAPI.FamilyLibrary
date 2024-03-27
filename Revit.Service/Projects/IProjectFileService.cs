using Revit.Entity.Project;

namespace Revit.Service.Projects
{
    public interface IProjectFileService
    {
        string ConvertFileSize(long fileSize);
        Task<IEnumerable<ProjectFolderDto>> UploadProjectFile(long folderId, ProjectUploadFileDto projectUploadFileDto);
    }
}
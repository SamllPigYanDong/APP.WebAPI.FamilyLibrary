using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Service.Projects;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Folder/{folderId}/File")]
    [AllowAnonymous]
    [UnitOfWork(IsTransactional = false)]
    public class ProjectsFileController : ControllerBase
    {
        private readonly IProjectFileService projectFileService;

       
        public ProjectsFileController(IProjectFileService projectFileService)
        {
            this.projectFileService = projectFileService;
        }



        [HttpPost]
        public async Task<IActionResult> UploadProjectFolder(long folderId, [FromForm]ProjectUploadFileDto  projectUploadFileDto)
        {
            var result =await projectFileService.UploadProjectFile(folderId, projectUploadFileDto);
            if (result != null )
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetError());
        }



    }
}

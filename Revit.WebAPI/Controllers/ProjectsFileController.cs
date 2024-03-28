using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Entity.Users;
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
        private readonly UserManager<R_User> userManager;

        public ProjectsFileController(IProjectFileService projectFileService, UserManager<R_User> userManager)
        {
            this.projectFileService = projectFileService;
            this.userManager = userManager;
        }



        [HttpPost]
        public async Task<IActionResult> UploadProjectFiles(long folderId, [FromForm]ProjectUploadFileDto  projectUploadFileDto)
        {
            var user=userManager.FindByNameAsync(this.Request.HttpContext.User.Identity.Name);
            var result =await projectFileService.UploadProjectFile(folderId, user.Result.Id, projectUploadFileDto);
            if (result != null )
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetError());
        }

       

    }
}

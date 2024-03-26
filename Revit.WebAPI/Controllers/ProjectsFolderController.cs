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
    [Route("api/Project/{ProjectId}/Folder")]
    [AllowAnonymous]
    [UnitOfWork(IsTransactional = false)]
    public class ProjectsFolderController : ControllerBase
    {
        private readonly IProjectService projectService;

        /// <summary>
        /// 项目控制类
        /// </summary>
        /// <param name="projectService"></param>
        public ProjectsFolderController(IProjectService projectService)
        {
            this.projectService = projectService;
        }


        [HttpGet()]
        public async Task<IActionResult> GetProjectFolders([FromQuery] ProjectGetFoldersDto projectGetFoldersDto)
        {
            var result = projectService.GetProjectPathFolders(projectGetFoldersDto);
            if (result != null && result.Count > 0)
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetNotFound());
        }

        [HttpPost()]
        public async Task<IActionResult> CreateProjectFolder([FromBody] ProjectCreateFolderDto projectCreateFolderDto)
        {
            var result = projectService.CreateProjectFolder(projectCreateFolderDto);
            if (result != null )
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetError());
        }



    }
}

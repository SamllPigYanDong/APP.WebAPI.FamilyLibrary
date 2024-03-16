using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Service.Projects;
using Revit.WebAPI.Auth;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [R_Authorize]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }


        [HttpGet]
        public IActionResult Get([FromBody]ProjectRequestDto pageRequest)
        {
            var result = projectService.GetProjects(pageRequest);
            if (result != null && result.Any())
            {
                return Ok(new ResponseResultDto() { Result = result, Code = ResponseCode.Success });
            }
            else
            {
                return BadRequest(new ResponseResultDto() { Code = ResponseCode.NotFound, Message = "该项目无成员。" });
            }
        }

        [HttpGet]
        [Route("Users")]
        public IActionResult GetUsers(long projectId)
        {
            var result = projectService.GetProjectUsers(projectId);
            if (result != null && result.Any())
            {
                return Ok(new ResponseResultDto() { Result = result, Code = ResponseCode.Success });
            }
            else
            {
                return BadRequest(new ResponseResultDto() { Code = ResponseCode.NotFound, Message = "该项目无成员。" });
            }
        }

        [HttpPost]  
        private void Post()
        { 
        
        
        }

        [HttpDelete]
        private void Delete()
        {


        }


        [HttpPut]
        private void Put()
        {


        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Revit.Service.Families;
using Revit.Entity.Family;
using Revit.Shared.Entity.Commons.Page;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Family;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamilyController : ControllerBase
    {
        private readonly IFamilyService familyService;
        private readonly IFamiyCategoryService famiyCategoryService;

        public FamilyController(IFamilyService familyService)
        {
            this.familyService = familyService;
            this.famiyCategoryService = famiyCategoryService;
        }

        //[HttpGet]
        //public async Task<ActionResult<R_Family>> GetFamilyAsync(long familyId)
        //{
        //    var family = await familyService.GetAsync(familyId);
        //    if (family is null)
        //    {
        //        return NoContent();
        //    }

        //    var familyDto = Mapper.Map<R_Family, FamilyDto>(family);
        //    return Ok(familyDto);
        //}

        [HttpGet]
        public async Task<ActionResult<ApiResponse<PagedList<FamilyDto>>>> GetAsync(
            [FromQuery] FamilyPageRequestDto parameters)
        {
            var pageList = await familyService.GetListAsync(parameters);
            if (pageList != null)
            {
                return Ok(new ApiResponse(pageList));
            }
            else { return NotFound(null); }
        }

        [HttpGet("User/{userId}")]
        public async Task<ActionResult<ApiResponse>> GetFamiliesAsync(long userId)
        {
            var families = await familyService.GetFamiliesByUser(userId);
            if (families.Any())
            {
                return Ok(new ApiResponse(families));
            }
            else { return NotFound(); }
        }

        [HttpPost("User/{creatorId}")]
        public async Task<ActionResult<ApiResponse<IEnumerable<FamilyDto>>>> UploadFamily( [FromRoute] long creatorId)
        {
            IEnumerable<FamilyDto> families = await familyService.UploadFiles(creatorId, new FamilyUploadDto() {  Files=Request.Form.Files});
            if (families.Any())
            {
                return Ok(new ApiResponse(families));
            }
            else { return NotFound(); }
        }

        [HttpGet("{familyId}")]
        public async Task<ActionResult<ApiResponse<byte[]>>> DownloadFamily(long familyId)
        {
            var stream  = await familyService.DownloadFamily(familyId);
            if (stream != null)
            {
                return Ok(new ApiResponse(stream));
            }
            else { return NotFound(); }
        }

        [HttpPut("{familyId}")]
        public async Task<ActionResult<ApiResponse<FamilyDto>>> AuditingFamily(long familyId,FamilyPutDto  familyPutDto)
        {
            var result = await familyService.AuditingFamily(familyId, familyPutDto);
            if (result != null)
            {
                return Ok(new ApiResponse(result));
            }
            else { return NotFound(); }
        }



    }
}
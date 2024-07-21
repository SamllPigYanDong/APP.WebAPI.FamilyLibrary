using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Net.Http.Json;
using Revit.Entity.Commons;
using Revit.Service.Permissions;
using Revit.Service.Families;
using Revit.Entity.Family;
using Revit.Entity.Project;
using Revit.Entity.Entity.Dtos.Family;
using System.Net.WebSockets;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamilyController : ControllerBase
    {
        private readonly IFamilyService familyService;
        private readonly IFamiyCategoryService famiyCategoryService;

        public FamilyController(IFamilyService familyService, IFamiyCategoryService  famiyCategoryService)
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
        public async Task<ActionResult<ResponseResultDto>> GetAsync(
            [FromQuery] PageRequestDto parameters)
        {
            var pageList = await familyService.GetListAsync(parameters);
            //var paginationMetadata = new
            //{
            //    totalCount = pageList.TotalCount,
            //    pageSize = pageList.PageSize,
            //    currentPage = pageList.PageIndex,
            //    totalPages = pageList.TotalCount,
            //    //previousePageLink=pageList.HasPrevious?Url.Link(nameof(GetFamiliesAsync),new
            //    //{
            //    //    pageNumber=pageList.CurrentPage-1,
            //    //    pigeSize=pageList.PageSize,
            //    //}):null,
            //    //nextPageLink=pageList.HasNext?Url.Link(nameof(GetFamiliesAsync),new
            //    //{
            //    //    pageNumber=pageList.CurrentPage+1,
            //    //    pigeSize=pageList.PageSize,
            //    //}):null
            //};
            //Response.Headers.Add("X-Pagination", new JsonResult(paginationMetadata).ToString());
            if (pageList != null)
            {
                return Ok(new ResponseResultDto(pageList));
            }
            else { return NotFound(); }
        }


        [HttpGet("userId")]
        //[ServiceFilter(typeof(CheckUserExistFilterAttribute))]
        public async Task<ActionResult<ResponseResultDto>> GetFamiliesAsync(long userId)
        {
            var families = await familyService.GetFamiliesByUser(userId);
            if (families.Any())
            {
                return Ok(new ResponseResultDto(families));
            }
            else { return NotFound(); }
        }

        [HttpPost]
        public async Task<ActionResult<ResponseResultDto>> UploadFamily( [FromForm] FamilyUploadDto filesDto)
        {
            IEnumerable<FamilyDto> families = await familyService.UploadFiles(filesDto);
            if (families.Any())
            {
                return Ok(new ResponseResultDto(families));
            }
            else { return NotFound(); }
        }


        [HttpGet("{familyId}")]
        public async Task<ActionResult<ResponseResultDto>> DownloadFamily(long familyId)
        {
            var stream  = await familyService.DownloadFamily(familyId);
            if (stream != null)
            {
                return Ok(new ResponseResultDto(stream));
            }
            else { return NotFound(); }
        }


        [HttpPut("{familyId}")]
        public async Task<ActionResult<ResponseResultDto>> AuditingFamily(long familyId,FamilyPutDto  familyPutDto)
        {
            var result = await familyService.AuditingFamily(familyId, familyPutDto);
            var count = await famiyCategoryService.SaveFamilyCategies(familyId, familyPutDto.CategoriesIds);
            if (result != null&&count==familyPutDto.CategoriesIds.Count)
            {
                return Ok(new ResponseResultDto(result));
            }
            else { return NotFound(); }
        }



    }
}
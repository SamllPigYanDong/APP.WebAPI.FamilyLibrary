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

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController( ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
        {
            var result = await categoryService.GetCategories();
            if (result != null)
            {
                return Ok(new ResponseResultDto(result));
            }
            else { return NotFound(); }
        }

        [HttpPost]
        public async Task<ActionResult<CategoryDto>> AddCategory(CategoryCreateDto createMessages)
        {
            var result = await categoryService.AddCategory( createMessages);
            if (result != null)
            {
                return Ok(new ResponseResultDto(result));
            }
            else { return NotFound(); }
        }

    }
}
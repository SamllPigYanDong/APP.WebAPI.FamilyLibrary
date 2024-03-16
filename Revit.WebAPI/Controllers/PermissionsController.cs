using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Permissions;
using Revit.Service.Permissions;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;

namespace Revit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [R_Authorize]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionService _permissionRepositiory;
        private readonly IMapper _mapper;

        public PermissionsController(IPermissionService permissionRepositiory, IMapper mapper)
        {
            _permissionRepositiory = permissionRepositiory;
            _mapper = mapper;
        }

        /// <summary>
        /// 获取所有权限
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        [UnitOfWork(IsTransactional = false)]
        public IActionResult All()
        {
            //获取所有权限
            var permissionDtos = _permissionRepositiory.GetAll();

            return Ok(permissionDtos);
        }

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="permissionCreateDto"></param>
        [HttpPost]
        public IActionResult Post([FromBody] PermissionCreateDto permissionCreateDto)
        {
            var R_Permission = _mapper.Map<R_Permission>(permissionCreateDto);
            //添加权限
            R_Permission = _permissionRepositiory.Add(R_Permission);

            if (R_Permission != null)
            {
                return Created(string.Empty, R_Permission.Id);
            }
            else
            {
                var responseResult = new ResponseResultDto();
                responseResult.SetError("请菜单编码，是否重复！");
                return BadRequest(responseResult);
            }
        }

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="id"></param>
        /// <param name="permissionUpdateDto"></param>
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] PermissionUpdateDto permissionUpdateDto)
        {
            //获取权限
            var R_Permission = _permissionRepositiory.Get(id);
            if (R_Permission == null)
            {
                var responseResult = new ResponseResultDto();
                responseResult.SetNotFound();
                return BadRequest(responseResult);
            }

            //更新字段
            _mapper.Map(permissionUpdateDto, R_Permission);
            var success = _permissionRepositiory.Update(R_Permission);

            if (success)
            {
                return NoContent();
            }
            else
            {
                var notFound = new ResponseResultDto();
                notFound.SetError("请菜单编码，是否重复！");
                return BadRequest(notFound);
            }
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //删除权限
            var success = _permissionRepositiory.Delete(id);

            if (success)
            {
                return NoContent();
            }
            else
            {
                var notFound = new ResponseResultDto();
                notFound.SetNotFound();
                return BadRequest(notFound);
            }
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.Service.Permissions;
using Revit.Service.Roles;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;

namespace Electric.API.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [R_Authorize]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleRepositiory;
        private readonly IRolePermissionService _rolePermissionRepositiory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<R_User> _userManager;
        private readonly RoleManager<R_Role> _roleManager;
        private readonly IMapper _mapper;

        public RolesController(IRoleService roleRepositiory, IRolePermissionService rolePermissionRepositiory, IHttpContextAccessor httpContextAccessor,
            UserManager<R_User> userManager, IMapper mapper, RoleManager<R_Role> roleManager)
        {
            _roleRepositiory = roleRepositiory;
            _rolePermissionRepositiory = rolePermissionRepositiory;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        /// <summary>
        /// 角色搜索
        /// </summary>
        /// <param name="rolePageRequestDto"></param>
        /// <returns></returns>
        [HttpGet]
        [UnitOfWork(IsTransactional = false)]
        public IActionResult Get([FromQuery] RolePageRequestDto rolePageRequestDto)
        {
            //角色搜索
            var rolePageResponseDto = _roleRepositiory.Query(rolePageRequestDto);

            return Ok(rolePageResponseDto);
        }

        /// <summary>
        /// 获取所有角色列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        [UnitOfWork(IsTransactional = false)]
        public IActionResult GetAll()
        {
            var roles = _roleRepositiory.GetAll();

            return Ok(roles);
        }

        /// <summary>
        /// 保存角色的权限列表
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <param name="rolePermissionDto">以,分割权限Id</param>
        /// <returns></returns>
        [HttpPut("{id}/permissions")]
        public async Task<IActionResult> SavePermissions(long id, [FromBody] RolePermissionDto rolePermissionDto)
        {
            //获取个人信息
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            //保存权限
            _rolePermissionRepositiory.SavePermissions(id, rolePermissionDto.PermissionIds, user.Id);

            return Ok();
        }

        /// <summary>
        /// 获取角色的权限列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}/permissions")]
        public IActionResult GetPermissions(long id)
        {
            //获取角色的权限列表
            var rolePermissionDtos = _rolePermissionRepositiory.GetRolePermissions(id);

            return Ok(rolePermissionDtos);
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roleCreateDto"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoleCreateDto roleCreateDto)
        {
            var eleRole = _mapper.Map<R_Role>(roleCreateDto);

            //获取登录的用户
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var creatorUser = await _userManager.FindByNameAsync(userName);

            //添加角色
            eleRole.CreatorId = creatorUser.Id;
            var result = await _roleManager.CreateAsync(eleRole);
            if (result.Succeeded)
            {
                return Created(string.Empty, eleRole);
            }
            else
            {
                var responseResult = new ResponseResultDto();
                responseResult.SetError("请检查角色名称，是否重复！");
                return BadRequest(responseResult);
            }
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleUpdateDto"></param>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] RoleUpdateDto roleUpdateDto)
        {
            //获取角色
            var eleRole = await _roleManager.FindByIdAsync(id.ToString());
            if (eleRole == null)
            {
                var responseResult = new ResponseResultDto();
                responseResult.SetNotFound();
                return BadRequest(responseResult);
            }

            //更新字段
            _mapper.Map(roleUpdateDto, eleRole);
            eleRole.LastModificationTime = DateTime.Now;
            var result = await _roleManager.UpdateAsync(eleRole);

            if (result.Succeeded)
            {
                return NoContent();
            }
            else
            {
                var notFound = new ResponseResultDto();
                notFound.SetError("请检查角色名称，是否重复！");
                return BadRequest(notFound);
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var responseResult = new ResponseResultDto();

            var eleRole = await _roleManager.FindByIdAsync(id.ToString());
            //初始化数据，不可删除
            if (id == 1)
            {
                responseResult.SetError("初始的角色，不可删除");
                return BadRequest(responseResult);
            }
            else if (eleRole == null)
            {
                responseResult.SetNotFound();
                return BadRequest(responseResult);
            }

            //删除角色
            await _roleManager.DeleteAsync(eleRole);
            return NoContent();
        }
    }
}

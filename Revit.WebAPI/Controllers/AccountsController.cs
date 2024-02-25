﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Accounts;
using Revit.Entity.Commons;
using Revit.Entity.Users;
using Revit.Service;
using Revit.Service.UnitOfWork;
using Revit.Service.Permissions;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;

namespace Revit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [R_Authorize]
    public class AccountsController : ControllerBase
    {
        private readonly IRolePermissionService _rolePermissionRepositiory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<R_User> _userManager;
        private readonly ILogger<AccountsController> _logger;
        private readonly ILoggerFactory loggerFactory;

        public AccountsController(IRolePermissionService rolePermissionRepositiory,IHttpContextAccessor httpContextAccessor,UserManager<R_User> userManager,ILogger<AccountsController> logger,ILoggerFactory loggerFactory)
        {
            this._rolePermissionRepositiory = rolePermissionRepositiory;
            this._httpContextAccessor = httpContextAccessor;
            this._userManager = userManager;
            this._logger = logger;
            var logger1 = loggerFactory.CreateLogger("MyLogLevel");
            logger1.LogInformation("123");
            this._logger.LogInformation("成功开启日志");
        }

        /// <summary>
        /// 获取个人信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [UnitOfWork(IsTransactional =false)]
        public async Task<IActionResult> Get()
        {
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var user=await _userManager.FindByNameAsync(userName);
            var roles=await _userManager.GetRolesAsync(user);

            //返回结果
            var accountDto = new AccountDto()
            {
                Roles = roles.ToArray(),
                Name = userName,
                Avatar = "",
                Introduction = string.IsNullOrEmpty(user.FullName) ? userName : user.FullName
            };

            return Ok(accountDto);
        }



        /// <summary>
        /// 获取授权列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("permissions")]
        [UnitOfWork(IsTransactional = false)]
        public async Task<IActionResult> GetPermissions()
        {
            //获取登录的用户名
            var userName = _httpContextAccessor.HttpContext?.User.Identity?.Name;
            if (string.IsNullOrWhiteSpace(userName))
            {
                return BadRequest();
            }
            var entity = await _userManager.FindByNameAsync(userName);
            var roles = await _userManager.GetRolesAsync(entity);

            var rolePermissions = new Dictionary<long, AccountPermissionsDto>();
            foreach (var roleName in roles)
            {
                //获取角色列表
                var _rolePermissions = _rolePermissionRepositiory.GetRolePermissions(roleName);
                //去掉重复的权限
                foreach (var permission in _rolePermissions)
                {
                    if (!rolePermissions.ContainsKey(permission.Id))
                    {
                        rolePermissions.Add(permission.Id, permission);
                    }
                }
            }
            //返回权限列表
            var list = rolePermissions.Values.ToList();
            return Ok(list);
        }

        [HttpPatch("password")]
        public async Task<IActionResult> Put([FromBody] AccountUpdatePasswordDto passwordDto)
        { 
            var userName= _httpContextAccessor.HttpContext.User.Identity.Name;
            var user=await _userManager.FindByNameAsync(userName);
            var result = await _userManager.CheckPasswordAsync(user,passwordDto.OldPassword);
            if (result)
            {
                var passwordHash = new PasswordHasher<R_User>();
                user.PasswordHash = passwordHash.HashPassword(user, passwordDto.NewPassword);
                await _userManager.UpdateAsync(user);
                return Ok();
            }
            //错误
            var responseResult = new ResponseResultDto();
            responseResult.SetError("原密码错误");
            return BadRequest(responseResult);
        }


        //public async Task<IActionResult> Logout()
        //{
        //    var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
        //    var user = await _userManager.FindByNameAsync(userName);

        //    _userManager.log


        //}

    }
}

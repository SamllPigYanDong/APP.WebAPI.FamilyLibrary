using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualBasic;
using Revit.Entity.Commons;
using Revit.Entity.Users;
using Revit.Service.UnitOfWork;
using Revit.Service.Users;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;

namespace Revit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [R_Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<R_User> _userManager;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUserService userRepository
            , IHttpContextAccessor httpContextAccessor
            , UserManager<R_User> userManager
            , IMapper mapper
            , IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 获取用户名称
        /// </summary>
        /// <param name="userPageRequestDto"></param>
        /// <returns></returns>
        [HttpGet]
        [UnitOfWork(IsTransactional = false)]
        public IActionResult Get([FromQuery] UserPageRequestDto userPageRequestDto)
        {
            //根据用户名搜索，分页返回用户列表

            var UserPageResponseDto = _userRepository.Query(userPageRequestDto);
            return Ok(UserPageResponseDto);
        }


        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userCreateDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserCreateDto userCreateDto)
        {
            var user = _mapper.Map<R_User>(userCreateDto);

            //获取登录的用户
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var creatorUser = await _userManager.FindByNameAsync(userName);
            //更新字段
            user.CreatorId = creatorUser.Id;
            user.EmailConfirmed = true;
            user.NormalizedUserName = user.UserName;
            user.SecurityStamp = DateTime.Now.Ticks.ToString();

            //密码
            PasswordHasher<R_User> ph = new PasswordHasher<R_User>();
            user.PasswordHash = ph.HashPassword(user, userCreateDto.Password);

            //添加用户
            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                return Created(string.Empty, user);
            }
            else
            {
                var responseResult = new ResponseResultDto();
                responseResult.SetError("请检查用户账号，是否重复！");
                return BadRequest(responseResult);
            }
        }



        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userUpdateDto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async Task<IActionResult> Put(long id, [FromBody] UserUpdateDto userUpdateDto)
        {

            //获取用户
            var responseResult = new ResponseResultDto();
            var rUser = await _userManager.FindByIdAsync(id.ToString());
            if (rUser == null)
            {
                responseResult.SetNotFound();
                return BadRequest(responseResult);
            }

            //更新密码
            if (userUpdateDto.Password == null)
            {
                userUpdateDto.Password = rUser.PasswordHash;
            }
            else
            {
                PasswordHasher<R_User> passwordHasher = new PasswordHasher<R_User>();
                rUser.PasswordHash = passwordHasher.HashPassword(rUser, userUpdateDto.Password);
            }

            //更新字段
            _mapper.Map(userUpdateDto, rUser);
            rUser.LastModificationTime = DateTime.Now;
            var result = await _userManager.UpdateAsync(rUser);
            if (!result.Succeeded)
            {
                return BadRequest(responseResult.SetError("更新失败，请检查账号是否重复。"));
            }

            //删除原本角色
            var oldRoles = await _userManager.GetRolesAsync(rUser);
            if (oldRoles != null && oldRoles.Count > 0)
            {
                await _userManager.RemoveFromRolesAsync(rUser, oldRoles);
            }

            //设置新角色
            result = await _userManager.AddToRolesAsync(rUser, userUpdateDto.RoleNames);

            if (result.Succeeded)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(responseResult.SetError("更新用户角色失败，请联系管理员。"));
            }

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(long id)
        {
            var responseResult = new ResponseResultDto();
            var rUser = await _userManager.FindByIdAsync(id.ToString());

            if (id == 1)
            {
                responseResult.SetError("初始的用户，不可删除");
                return BadRequest(responseResult);
            }
            else if (rUser == null)
            {
                responseResult.SetNotFound();
                return BadRequest(responseResult);
            }

            await _userManager.DeleteAsync(rUser);
            return NoContent();

        }
    }



}

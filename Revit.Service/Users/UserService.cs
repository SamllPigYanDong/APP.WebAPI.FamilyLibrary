using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

using Revit.Entity.Users;
using Revit.Service.Commons;
using Revit.Repository;
using Revit.Entity.Roles;

namespace Revit.Service.Users
{
    /// <summary>
    /// 用户
    /// </summary>
    public class UserService : BaseService, IUserService
    {
        private readonly IBaseRepository<R_User> _userRepository;
        private readonly IBaseRepository<R_Role> _roleRepository;
        private readonly IBaseRepository<R_UserRole> _userRoleRepository;

        private readonly IMapper _mapper;

        public UserService(IBaseRepository<R_User> userRepository
            , IBaseRepository<R_Role> roleRepository
            , IBaseRepository<R_UserRole> userRoleRepository, IMapper mapper):base(mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
        }

        /// <summary>
        /// 搜索用户
        /// </summary>
        /// <param name="userPageRequestDto"></param>
        /// <returns></returns>
        public UserPageResponseDto Query(UserPageRequestDto userPageRequestDto)
        {
            var result = new UserPageResponseDto();
            //过滤
            var query = _userRepository.GetQueryable();
            if (!string.IsNullOrEmpty(userPageRequestDto.UserName))
            {
                query = query.Where(x => x.UserName.Equals(userPageRequestDto.UserName));
            }
            userPageRequestDto.Page = userPageRequestDto.Page < 1 ? 1 : userPageRequestDto.Page;

            //获取总数、用户列表
            var count = query.Count();
            var skip = (userPageRequestDto.Page - 1) * userPageRequestDto.PrePage;
            var list = _userRepository.GetPagedList(skip, userPageRequestDto.PrePage, query);
            result.PageIndex = userPageRequestDto.Page;
            result.PageSize = userPageRequestDto.PrePage;
            result.TotalCount = count;

            //转换实体
            var userDtos = new List<UserDto>();
            foreach (var item in list)
            {
                var userDto = _mapper.Map<UserDto>(item);

                //创建者
                var creator = _userRepository.Get(userDto.CreatorId);
                userDto.Creator = _mapper.Map<UserDto>(creator);

                //获取用户关联的角色列表
                var roleList = (from r in _roleRepository.GetQueryable()
                                join ur in _userRoleRepository.GetQueryable() on r.Id equals ur.RoleId
                                where ur.UserId == item.Id
                                select r).ToList();
                userDto.Roles = _mapper.Map<List<RoleDto>>(roleList);

                userDtos.Add(userDto);
            }
            result.Users = userDtos;

            return result;
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public List<string> GetRoles(string userName)
        {
            var roles = (from r in _roleRepository.GetQueryable()
                         join ur in _userRoleRepository.GetQueryable() on r.Id equals ur.RoleId
                         join u in _userRepository.GetQueryable() on ur.UserId equals u.Id
                         where u.UserName == userName
                         select r.Name).ToList();

            return roles;
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns></returns>
        public List<UserAllDto> GetAll()
        {
            var list = _userRepository.GetAll();

            return _mapper.Map<List<UserAllDto>>(list);
        }
    }
}

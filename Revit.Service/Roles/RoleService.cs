using AutoMapper;

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;
using Revit.Service.Commons;
using Revit.Repository;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.Entity.Commons;
using Revit.Entity.Permissions;
using Revit.Service.Permissions;
using Revit.Shared.Entity.Commons.Page;
using Revit.Shared.Entity.Roles;
using Revit.Shared.Entity.Users;

namespace Revit.Service.Roles
{
    /// <summary>
    /// 角色
    /// </summary>
    public class RoleService : BaseService, IRoleService
    {
        private readonly IBaseRepository<R_Role> _roleRepository;
        private readonly IBaseRepository<R_User> _userRepository;
        private readonly IBaseRepository<R_RolePermission> _rolePermissionRepository;
        private readonly IMapper _mapper;

        public RoleService(IBaseRepository<R_Role> roleRepository
            , IBaseRepository<R_User> userRepository
            , IBaseRepository<R_RolePermission> rolePermissionRepository
            , IMapper mapper):base(mapper)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _rolePermissionRepository = rolePermissionRepository;
        }

        /// <summary>
        /// 搜索角色
        /// </summary>
        /// <param name="rolePageRequestDto"></param>
        /// <returns></returns>
        public IPagedList<RoleDto> Query(RolePageRequestDto rolePageRequestDto)
        {
            var query = _roleRepository.GetQueryable();
            if (!string.IsNullOrEmpty(rolePageRequestDto.Name))
            {
                query = query.Where(x => x.Name.Equals(rolePageRequestDto.Name));
            }

            IPagedList<RoleDto> result = new PagedList<R_Role, RoleDto>(query, (list) => {
                var roleDtos = new List<RoleDto>();
                foreach (var item in list)
                {
                    var roleDto = _mapper.Map<RoleDto>(item);

                    //创建者
                    var creator = _userRepository.Get(roleDto.CreatorId);
                    roleDto.Creator = _mapper.Map<UserDto>(creator);
                    roleDtos.Add(roleDto);
                }
                return roleDtos;
            }, rolePageRequestDto.PageIndex, rolePageRequestDto.PageSize, 1);

            return result;
        }

        /// <summary>
        /// 获取所有角色列表
        /// </summary>
        /// <param name="rolePageRequestDto"></param>
        /// <returns></returns>
        public IEnumerable<RoleDto> GetAll()
        {
            var list = _roleRepository.GetAll();

            //转换实体
            var roleDtos = new List<RoleDto>();
            foreach (var item in list)
            {
                var roleDto = _mapper.Map<RoleDto>(item);

                //创建者
                var creator = _userRepository.Get(roleDto.CreatorId);
                roleDto.Creator = _mapper.Map<UserDto>(creator);
                roleDtos.Add(roleDto);
            }

            return roleDtos;
        }
    }
}

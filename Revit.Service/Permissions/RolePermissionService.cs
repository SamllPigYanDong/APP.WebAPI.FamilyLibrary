using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Revit.EntityFrameworkCore;
using Revit.Entity.Accounts;
using Revit.Entity.Commons;
using Revit.Entity.Permissions;
using Revit.Entity.Roles;
using System.Security;
using Revit.Service.Commons;

namespace Revit.Service.Permissions
{
    public class RolePermissionService : BaseService, IRolePermissionService
    {
        public RolePermissionService(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }


        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public List<AccountPermissionsDto> GetRolePermissions(string roleName)
        {
            //根据角色获取权限列表
            var permissions = (from permission in _dbContext.R_Permission
                               join rolePermisson in _dbContext.R_RolePermission on permission.Id equals rolePermisson.PermissionId
                               join role in _dbContext.Roles on rolePermisson.RoleId equals role.Id
                               where role.NormalizedName == roleName
                               select permission
                     ).ToList();

            //对象映射转化
            var permissionsDtos = _mapper.Map<List<AccountPermissionsDto>>(permissions);

            return permissionsDtos;
        }

        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<PermissionDto> GetRolePermissions(long roleId)
        {
            var permissions = new List<PermissionDto>();
            var list = _dbContext.R_RolePermission.Where(x => x.RoleId == roleId).ToList();
            var mapper = MappingProfile.CreateMapper();
            foreach (var item in list)
            {
                var elePermission = _dbContext.R_Permission.FirstOrDefault(x => x.Id == item.PermissionId);

                var permissionDto = mapper.Map<PermissionDto>(elePermission);
                permissions.Add(permissionDto);
            }

            return permissions;
        }



        /// <summary>
        /// 保存角色的权限列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="permissionIds"></param>
        /// <param name="CreatorId"></param>
        /// <returns></returns>
        public bool SavePermissions(long roleId, List<long> permissionIds, long creatorId)
        {
            var result = _dbContext.R_RolePermission.Where(x => x.RoleId == roleId);
            _dbContext.R_RolePermission.RemoveRange(result);
            var list = new List<R_RolePermission>();
            foreach (var item in permissionIds)
            {
                var eleRolePermission = new R_RolePermission();
                eleRolePermission.RoleId = roleId;
                eleRolePermission.PermissionId = item;
                eleRolePermission.CreationTime = DateTime.Now;
                eleRolePermission.CreatorId = creatorId;
                list.Add(eleRolePermission);
            }
            _dbContext.AddRange(list);
            return _dbContext.SaveChanges() > 0;
        }

    }
}
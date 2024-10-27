using Revit.Entity.Commons;
using Revit.Shared.Entity.Commons.Page;
using Revit.Shared.Entity.Roles;

namespace Revit.Service.Roles
{
    public interface IRoleService
    {
        /// <summary>
        /// 获取所有角色列表
        /// </summary>
        /// <param name="rolePageRequestDto"></param>
        /// <returns></returns>
        IEnumerable<RoleDto> GetAll();
        RoleDto GetRole(long id);

        /// <summary>
        /// 搜索角色
        /// </summary>
        /// <param name="rolePageRequestDto"></param>
        /// <returns></returns>
        IPagedList<RoleDto> Query(RolePageRequestDto rolePageRequestDto);
    }
}
using Revit.Entity.Roles;

namespace Revit.Service.Roles
{
    public interface IRoleService
    {
        List<RoleDto> GetAll();
        RolePageResponseDto Query(RolePageRequestDto requestDto);
    }
}
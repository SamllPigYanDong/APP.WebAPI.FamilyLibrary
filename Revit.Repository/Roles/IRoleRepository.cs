using Revit.Entity.Roles;

namespace Revit.Repository.Roles
{
    public interface IRoleRepository
    {
        List<RoleDto> GetAll();
        RolePageResponseDto Query(RolePageRequestDto requestDto);
    }
}
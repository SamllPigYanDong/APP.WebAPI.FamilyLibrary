using Revit.Entity.Permissions;

namespace Revit.Service.Permissions
{
    public interface IPermissionService
    {
        R_Permission Add(R_Permission elePermission);
        bool Delete(long id);
        R_Permission? Get(long id);
        List<PermissionDto> GetAll();
        bool Update(R_Permission elePermission);
    }
}
using Revit.Entity.Permissions;

namespace Revit.Repository.Permissions
{
    public interface IPermissionRepositiory
    {
        R_Permission Add(R_Permission elePermission);
        bool Delete(long id);
        R_Permission? Get(long id);
        List<PermissionDto> GetAll();
        bool Update(R_Permission elePermission);
    }
}
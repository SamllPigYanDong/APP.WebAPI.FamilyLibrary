using Revit.Entity.Users;

namespace Revit.Service.Users
{
    public interface IUserService
    {
        List<string> GetRoles(string userName);
        UserPageResponseDto Query(UserPageRequestDto userPageRequestDto);
    }
}
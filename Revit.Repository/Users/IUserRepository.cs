using Revit.Entity.Users;

namespace Revit.Repository.Users
{
    public interface IUserRepository
    {
        List<string> GetRoles(string userName);
        UserPageResponseDto Query(UserPageRequestDto userPageRequestDto);
    }
}
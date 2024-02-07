using AutoMapper;
using Revit.EntityFrameworkCore;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.Repository.Commons;
using Arch.EntityFrameworkCore.UnitOfWork;

namespace Revit.Repository.Users
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext, IMapper mapper,IUnitOfWork unitOfWork) : base(dbContext, mapper,unitOfWork)
        {
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
            var query = _unitOfWork.GetRepository<R_User>().GetAll();
            if (!string.IsNullOrEmpty(userPageRequestDto.Name))
            {
                query = query.Where(x => x.UserName.Contains(userPageRequestDto.Name));
            }
            userPageRequestDto.Page = userPageRequestDto.Page < 1 ? 1 : userPageRequestDto.Page;

            //获取总数、用户列表
            var count = query.Count();
            var list = query.Skip((userPageRequestDto.Page - 1) * userPageRequestDto.PrePage).Take(userPageRequestDto.PrePage).ToList();
            result.Page = userPageRequestDto.Page;
            result.PrePage = userPageRequestDto.PrePage;
            result.Total = count;

            //转换实体
            var userDtos = new List<UserDto>();
            foreach (var item in list)
            {
                var userDto = _mapper.Map<UserDto>(item);

                //创建者
                var creator = _dbContext.Users.FirstOrDefault(x => x.Id == userDto.CreatorId);
                userDto.Creator = _mapper.Map<UserDto>(creator);

                //获取用户关联的角色列表
                var roleList = (from r in _dbContext.Roles
                                join ur in _dbContext.UserRoles on r.Id equals ur.RoleId
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
            var roles = (from r in _dbContext.Roles
                         join ur in _dbContext.UserRoles on r.Id equals ur.RoleId
                         join u in _dbContext.Users on ur.UserId equals u.Id
                         where u.UserName == userName
                         select r.Name).ToList();

            return roles;
        }

    }
}

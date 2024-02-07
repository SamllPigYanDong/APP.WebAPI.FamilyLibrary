using AutoMapper;
using Revit.Entity.Permissions;
using Revit.Entity.Users;
using Revit.EntityFrameworkCore;
using Revit.Repository.Commons;

namespace Revit.Repository.Permissions
{
    public class PermissionRepositiory : BaseRepository, IPermissionRepositiory
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly IMapper _mapper;

        public PermissionRepositiory(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <returns></returns>
        public List<PermissionDto> GetAll()
        {
            var permissionDtos = new List<PermissionDto>();
            var list = _dbContext.R_Permission.ToList();

            foreach (var item in list)
            {
                var permissionDto = _mapper.Map<PermissionDto>(item);

                //创建者
                var creator = _dbContext.Users.FirstOrDefault(x => x.Id == permissionDto.CreatorId);
                permissionDto.Creator = _mapper.Map<UserDto>(creator);
                permissionDtos.Add(permissionDto);
            }

            return permissionDtos;
        }

        /// <summary>
        /// 获取权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public R_Permission? Get(long id)
        {
            var item = _dbContext.R_Permission.FirstOrDefault(x => x.Id == id);
            return item;
        }

        /// <summary>
        /// 更新权限信息
        /// </summary>
        /// <param name="elePermission"></param>
        /// <returns></returns>
        public bool Update(R_Permission elePermission)
        {
            var count = _dbContext.R_Permission.Count(x => x.Code == elePermission.Code && x.Id != elePermission.Id);
            if (count > 0)
            {
                return false;
            }

            elePermission.LastModificationTime = DateTime.Now;
            _dbContext.Update(elePermission);
            _dbContext.SaveChanges();

            return true;
        }

        /// <summary>
        /// 更新权限信息
        /// </summary>
        /// <param name="elePermission"></param>
        /// <returns></returns>
        public R_Permission Add(R_Permission elePermission)
        {
            var count = _dbContext.R_Permission.Count(x => x.Code == elePermission.Code);
            if (count > 0)
            {
                return null;
            }

            _dbContext.Add(elePermission);
            _dbContext.SaveChanges();

            return elePermission;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(long id)
        {
            var entity = _dbContext.R_Permission.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return false;
            }

            _dbContext.Remove(entity);
            _dbContext.SaveChanges();

            return true;
        }
    }
}

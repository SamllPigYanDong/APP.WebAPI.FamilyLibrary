using AutoMapper;
using Revit.Entity.Permissions;
using Revit.Entity.Users;
using Revit.Repository;
using Revit.Service.Commons;

namespace Revit.Service.Permissions
{
    public class PermissionService : BaseService,IPermissionService
    {
        private readonly IBaseRepository<R_Permission> _familiesRepository;
        private readonly IBaseRepository<R_User> _userRepository;

        private readonly IMapper _mapper;

        public PermissionService(IBaseRepository<R_Permission> permissionsRepository, IBaseRepository<R_User> userRepository, IMapper mapper):base(mapper)
        {
            _mapper = mapper;
            _familiesRepository = permissionsRepository;
            _userRepository = userRepository;
        }

        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <returns></returns>
        public List<PermissionDto> GetAll()
        {
            var permissionDtos = new List<PermissionDto>();
            var list = _familiesRepository.GetAll();

            foreach (var item in list)
            {
                var permissionDto = _mapper.Map<PermissionDto>(item);

                //创建者
                var creator = _userRepository.Get(permissionDto.CreatorId);
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
            var item = _familiesRepository.Get(id);
            return item;
        }

        /// <summary>
        /// 更新权限信息
        /// </summary>
        /// <param name="R_Permission"></param>
        /// <returns></returns>
        public bool Update(R_Permission R_Permission)
        {
            var count = _familiesRepository.Count(x => x.Code == R_Permission.Code && x.Id != R_Permission.Id);
            if (count > 0)
            {
                return false;
            }

            R_Permission.LastModificationTime = DateTime.Now;
            _familiesRepository.Update(R_Permission);

            return true;
        }

        /// <summary>
        /// 更新权限信息
        /// </summary>
        /// <param name="R_Permission"></param>
        /// <returns></returns>
        public R_Permission Add(R_Permission R_Permission)
        {
            var count = _familiesRepository.Count(x => x.Code == R_Permission.Code);
            if (count > 0)
            {
                return null;
            }

            _familiesRepository.Add(R_Permission);

            return R_Permission;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(long id)
        {
            var entity = _familiesRepository.Get(id);
            if (entity == null)
            {
                return false;
            }

            _familiesRepository.Delete(entity);

            return true;
        }
    }
}

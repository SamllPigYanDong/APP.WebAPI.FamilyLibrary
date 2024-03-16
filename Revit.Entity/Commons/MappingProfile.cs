using AutoMapper;
using Revit.Entity.Accounts;
using Revit.Entity.Permissions;
using Revit.Entity.Project;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Commons
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<R_Permission, AccountPermissionsDto>();
            CreateMap<R_Permission, PermissionDto>();
            CreateMap<PermissionCreateDto, R_Permission>();
            CreateMap<PermissionUpdateDto, R_Permission>();

            CreateMap<R_User, UserDto>();
            CreateMap<UserUpdateDto, R_User>();
            CreateMap<UserCreateDto, R_User>();

            CreateMap<R_Role, RoleDto>();
            CreateMap<RoleCreateDto, R_Role>();
            CreateMap<RoleUpdateDto, R_Role>();

            CreateMap<R_Project, ProjectResponseDto>();
        }

        /// <summary>
        /// 创建映射对象
        /// </summary>
        /// <returns></returns>
        public static IMapper CreateMapper()
        {
            //创建配置对象
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            //创建映射对象
            var mapper = configuration.CreateMapper();

            return mapper;
        }
    }
}

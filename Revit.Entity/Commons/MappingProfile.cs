using AutoMapper;
using Revit.Entity.Accounts;
using Revit.Entity.Entity.Dtos.Family;
using Revit.Entity.Family;
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
            CreateMap<R_User, AccountDto>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.FullName))
                .ForMember(x => x.Account, opt => opt.MapFrom(x => x.UserName))
                .ForMember(x => x.UserId, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.UserPhoneNumber, opt => opt.MapFrom(x => x.PhoneNumber));
            CreateMap<UserUpdateDto, R_User>();
            CreateMap<UserCreateDto, R_User>();

            CreateMap<R_Role, RoleDto>();
            CreateMap<RoleCreateDto, R_Role>();
            CreateMap<RoleUpdateDto, R_Role>();

            CreateMap<R_Project, ProjectResponseDto>();
            CreateMap<ProjectPostPutDto, R_Project>();

            CreateMap<R_ProjectFolder, ProjectFolderDto>();


            //page对应
            CreateMap<PageRequestDto, PageResponseDto>()
                .ForMember(x => x.TotalCount, opt => opt.MapFrom(x => x.PageSize * x.PageIndex))
                .ForMember(x => x.PageIndex, opt => opt.MapFrom(x => x.PageIndex))
                .ForMember(x => x.PageSize, opt => opt.MapFrom(x => x.PageSize));
            //family 与dto对应
            CreateMap<R_Family, FamilyDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.SameFileKey, opt => opt.MapFrom(x => x.SameFileKey));
            CreateMap<FamilyPutDto, R_Family>();
            CreateMap<CategoryCreateDto, R_Category>();
            CreateMap<R_Category, CategoryDto>();
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

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Revit.EntityFrameworkCore;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.Repository.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Repository.Roles
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public RolePageResponseDto Query(RolePageRequestDto requestDto)
        {
            var result = new RolePageResponseDto();
            var query = _dbContext.Roles.Where(x => 1 == 1);
            if (!string.IsNullOrEmpty(requestDto.Name))
            {
                query = query.Where(x => x.Name.Equals(requestDto.Name));
            }
            requestDto.Page = requestDto.Page < 1 ? 1 : requestDto.Page;
            //按页码取数据
            var count = query.Count();
            var skipCount = (requestDto.Page - 1) * requestDto.PrePage;
            var list = query.Skip(skipCount).Take(requestDto.PrePage).ToList();
            result.Page = requestDto.Page;
            result.PrePage = requestDto.PrePage;
            result.Total = count;

            //转换实体
            var roleDtos = new List<RoleDto>();
            foreach (var item in list)
            {
                var roleDto = _mapper.Map<RoleDto>(item);

                //创建者
                var creator = _dbContext.Users.FirstOrDefault(x => x.Id == roleDto.CreatorId);
                roleDto.Creator = _mapper.Map<UserDto>(creator);
                roleDtos.Add(roleDto);
            }
            result.Roles = roleDtos;

            return result;
        }

        public List<RoleDto> GetAll()
        {
            var repository = _dbContext.Roles.ToList();

            var roleDtos = new List<RoleDto>();
            foreach (var item in repository)
            {
                var roleDto = _mapper.Map<RoleDto>(item);

                //创建者
                var creator = _dbContext.Users.FirstOrDefault(x => x.Id == roleDto.CreatorId);
                roleDto.Creator = _mapper.Map<UserDto>(creator);
                roleDtos.Add(roleDto);
            }

            return roleDtos;
        }
    }
}

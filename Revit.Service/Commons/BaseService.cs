using AutoMapper;
using Revit.EntityFrameworkCore;

namespace Revit.Service.Commons
{
    public class BaseService
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly IMapper _mapper;

        public BaseService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }



    }
}

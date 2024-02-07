using Abp.Domain.Uow;
using AutoMapper;
using Revit.EntityFrameworkCore;

namespace Revit.Repository.Commons
{
    public class BaseRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseRepository(ApplicationDbContext dbContext, IMapper mapper,IUnitOfWork unitOfWork)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }



    }
}

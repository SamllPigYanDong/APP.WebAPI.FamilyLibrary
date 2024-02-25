using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int AddRange(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity? Get(long id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetPagedList(int skip, int take, IQueryable<TEntity> queryable)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public T Query<T>(Func<IQueryable<TEntity>, T> queryMethod)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

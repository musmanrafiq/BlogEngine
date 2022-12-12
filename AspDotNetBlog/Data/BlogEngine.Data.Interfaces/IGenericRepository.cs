using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogEngine.Data.Interfaces
{
    public interface IGenericRepository<TEntity, TKey>
    {
        Task<List<TEntity>> GetAsync();
        TEntity Add(TEntity entity);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter);
    }
}

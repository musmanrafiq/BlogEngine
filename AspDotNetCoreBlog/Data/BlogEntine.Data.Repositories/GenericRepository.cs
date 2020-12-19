using BlogEngine.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEntine.Data.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private IBlogEngineDbContext dbContext;
        private DbSet<TEntity> dbSet;

        public GenericRepository(IBlogEngineDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }
        public virtual async Task<List<TEntity>> GetAsync()
        {
            return await dbSet.ToListAsync();
        }
    }
}

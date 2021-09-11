using BlogEngine.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private IBlogEngineDbContext dbContext;
        private DbSet<TEntity> dbSet;

        public DbSet<TEntity> DbSet
        {
            get => dbSet ?? (dbSet = DbContext.Set<TEntity>());
            set => dbSet = value;
        }

        public IBlogEngineDbContext DbContext
        {
            get { return dbContext; }
            private set { dbContext = value; }
        }
        public GenericRepository(IBlogEngineDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }
        public virtual async Task<List<TEntity>> GetAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual TEntity Add(TEntity entity)
        {
            var entry = dbSet.Add(entity).Entity;
            return entry;
        }
    }
}

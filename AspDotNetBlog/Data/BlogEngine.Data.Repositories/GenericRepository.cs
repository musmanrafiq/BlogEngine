using BlogEngine.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public virtual TEntity FindById(TKey key)
        {
            var entry = dbSet.Find(key);
            return entry;
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
       string includeProperties = "")
        {
            IQueryable<TEntity> Query = DbSet;

            if (filter != null)
            {
                Query = Query.Where(filter);
            }

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (string IncludeProperty in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Query = Query.Include(IncludeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(Query);
            }
            return Query;
        }

        public virtual Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> Query = DbSet;
            return Query.Where(filter).SingleOrDefaultAsync();
        }

        public virtual Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> Query = DbSet;
            return Query.Where(filter).ToListAsync();
        }
    }
}

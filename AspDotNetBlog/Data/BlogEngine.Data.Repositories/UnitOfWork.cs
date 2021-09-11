using BlogEngine.Data.Interfaces;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IBlogEngineDbContext _dbContext;

        public UnitOfWork(IBlogEngineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ReloadEntites()
        {
            await _dbContext.ReloadEntitiesAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}

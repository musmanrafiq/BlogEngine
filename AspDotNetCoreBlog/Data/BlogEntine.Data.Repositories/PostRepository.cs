using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;

namespace BlogEntine.Data.Repositories
{
    public class PostRepository : GenericRepository<Post, int>, IPostRepository
    {
        public PostRepository(IBlogEngineDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;

namespace BlogEngine.Data.Repositories
{
    public class PostRepository : GenericRepository<Post, int>, IPostRepository
    {
        public PostRepository(IBlogEngineRepositoryContext dbContext) : base(dbContext)
        {
        }
    }
}

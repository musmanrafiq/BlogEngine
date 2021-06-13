using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;

namespace BlogEngine.Data.Repositories
{
    public class PromptRepository : GenericRepository<Prompt, int>, IPromptRepository
    {
        public PromptRepository(IBlogEngineRepositoryContext dbContext) : base(dbContext)
        {
        }
    }
}

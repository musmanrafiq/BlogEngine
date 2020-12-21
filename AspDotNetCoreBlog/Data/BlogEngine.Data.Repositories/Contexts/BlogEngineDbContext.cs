using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repositories.Contexts
{
    public class BlogEngineDbContext : DbContext, IBlogEngineRepositoryContext, IBlogEngineDbContext
    {

        public BlogEngineDbContext(DbContextOptions<BlogEngineDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public async Task ReloadEntitiesAsync()
        {
            var entities = base.ChangeTracker.Entries().ToList();
            foreach (var entity in entities)
            {
                await entity.ReloadAsync();
            }
        }
    }
}

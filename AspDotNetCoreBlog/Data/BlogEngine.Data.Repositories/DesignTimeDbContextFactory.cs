using BlogEngine.Data.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlogEngine.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BlogEngineDbContext>
    {
        public BlogEngineDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BlogEngineDbContext>();
            builder.UseSqlite("Filename=E:\\dbs\\ublog.db");
            return new BlogEngineDbContext(builder.Options);
        }
    }
}

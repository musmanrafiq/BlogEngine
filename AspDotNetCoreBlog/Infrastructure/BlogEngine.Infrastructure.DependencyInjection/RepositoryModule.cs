using BlogEngine.Data.Interfaces;
using BlogEntine.Data.Repositories;
using BlogEntine.Data.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogEngine.Infrastructure.DependencyInjection
{
    public class RepositoryModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaulConnection");
            services.AddDbContext<BlogEngineDbContext>(
                options => options.UseSqlite(
                    connectionString,
                    sqlLiteOptions => sqlLiteOptions.MigrationsAssembly("BlogEntine.Data.Repositories")));

            services.AddScoped<IBlogEngineRepositoryContext, BlogEngineDbContext>();
            services.AddScoped<IUnitOfWork>(unit => new UnitOfWork(unit.GetService<IBlogEngineRepositoryContext>()));

            services.AddScoped<IPostRepository, PostRepository>();

        }
    }
}

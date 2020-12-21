using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Repositories;
using BlogEngine.Data.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogEngine.Infrastructure.DependencyInjection
{
    public class RepositoryModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BlogEngineDbContext>(
                options => options.UseSqlite(
                    connectionString,
                    sqlLiteOptions => sqlLiteOptions.MigrationsAssembly("BlogEngine.Data.Repositories")));

            services.AddScoped<IBlogEngineRepositoryContext, BlogEngineDbContext>();
            services.AddScoped<IUnitOfWork>(unit => new UnitOfWork(unit.GetService<IBlogEngineRepositoryContext>()));

            services.AddScoped<IPostRepository, PostRepository>();

        }
    }
}

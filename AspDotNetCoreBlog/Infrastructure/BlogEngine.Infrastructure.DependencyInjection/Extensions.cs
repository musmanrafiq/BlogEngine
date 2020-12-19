using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogEngine.Infrastructure.DependencyInjection
{
    public static class Extensions
    {
        public static void RegisterServices(this IServiceCollection service, IConfiguration configuration)
        {
            RepositoryModule.Configure(service, configuration);
        }
    }
}

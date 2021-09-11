using AutoMapper;
using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Business.Services;
using BlogEngine.Business.Services.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace BlogEngine.Infrastructure.DependencyInjection.Modules
{
    public class ServiceModule
    {
        public static void Configure(IServiceCollection services)
        {
            // setup
            var config = ModelMapper.Configure();
            IMapper mapper = config.CreateMapper();

            // registration
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPromptService, PromptService>();
            services.AddSingleton(mapper);
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections;
using System.Collections.Generic;
using UBlog.Data.DummyData;
using UBlog.Data.Entities;
using UBlog.Data.Interfaces;
using UBlog.Data.Repositories;

namespace UBlog
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            var dummyPosts = DummyDataProvider.GetBlogPosts();
            services.AddScoped<IBlogPostRepository>(p => new BlogPostRepository(dummyPosts));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

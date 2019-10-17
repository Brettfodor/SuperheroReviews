using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SuperHeroReviews.Models;
using SuperHeroReviews.Repository;
using SuperHeroReviews.Data;


namespace SuperHeroReviews
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<SuperContext>();
            services.AddScoped<IRepository<HeroModel>, HeroRepository>();
            services.AddScoped<IRepository<ReviewModel>, ReviewRepository>();
            services.AddScoped<IRepository<UniverseModel>, UniverseRepository>();


        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

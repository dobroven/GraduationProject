using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApp.Data;
using AspNetCoreApp.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AspNetCoreApp.Data.Repository;
using AspNetCoreApp.Data.Models;

namespace AspNetCoreApp
{
    public class Startup
    {
        private IConfigurationRoot ConfString;

        public Startup(IHostingEnvironment HostEnv)
        {
            ConfString = new ConfigurationBuilder().SetBasePath(HostEnv.ContentRootPath).AddJsonFile("DbSettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RestaurantDBContext>(Options => Options.UseSqlServer(ConfString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IDishes, DishRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            services.AddTransient<IOrders, OrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => RestaurantCart.GetCart(sp));
            
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{Id?}");
                routes.MapRoute(name: "categoryFilter", template: "Dish/{action}/{category?}", defaults: new { Controller = "Dish", Action = "List" });
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                RestaurantDBContext Context = scope.ServiceProvider.GetRequiredService<RestaurantDBContext>();
                DBObjects.Initial(Context);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreBasics.BLL;
using EFCoreBasics.BLL.Interface;
using EFCoreBasics.DAL;
using EFCoreBasics.DAL.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFCoreTestingWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<ICustomerBLL, CustomerBLL>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            //services.AddScoped<ICustomerRepository,MockCustomerRepository>(); //worked
            //services.AddScoped<AppDbContext>();

            //WORKED When We have define DbContextOptions in AppDbContext class
            //services.AddDbContext<AppDbContext>(options =>
            //    options.UseSqlServer("EFCoreBasicsDbConnString"));


            //WORKED When We have NOT define DbContextOptions in AppDbContext class
            services.AddDbContext<AppDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

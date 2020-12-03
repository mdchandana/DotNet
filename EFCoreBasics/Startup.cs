using EFCoreBasics.BLL;
using EFCoreBasics.BLL.Interface;
using EFCoreBasics.DAL;
using EFCoreBasics.DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBasics
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {


            ///WORKED
            //var provider = new ServiceCollection()
            //             .AddDbContext<AppDbContext>()
            //             .AddScoped<ICustomerRepository, CustomerRepository>()
            //             .BuildServiceProvider();




            //WORKED NICELY ----------------------------------------------------------------
            //Here BLL calling DAL
            //When Instantiating CustomerBLL Need ICustomerRepository
            //Next When Instantiating CustomerRepository Need AppDbContext

            var provider = new ServiceCollection()
                                    .AddScoped<AppDbContext>()
                                    .AddScoped<ICustomerRepository, CustomerRepository>()
                                    .AddScoped<ICustomerBLL,CustomerBLL>()
                                    .BuildServiceProvider();

            return provider;
        }
    }
}

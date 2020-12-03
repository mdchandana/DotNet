using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipendencyInjectionBasics
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            ///This also worked.....
            //var provider = new ServiceCollection()                         
            //             .AddScoped<IEmployeeRepository, MockEmployeeRepository>()
            //             .BuildServiceProvider();

            ///This also worked.....
            var provider = new ServiceCollection()
                         .AddScoped<MockEmployeeRepository>()
                         .AddScoped<IEmployeeRepository, MockEmployeeRepository>()
                         .BuildServiceProvider();

            return provider;
        }
    }
}

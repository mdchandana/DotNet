
using IrrigationWebSystem.ApplicationCore.Interfaces;
using IrrigationWebSystem.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            //services.AddScoped<IEmployeeService, EmployeeService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}

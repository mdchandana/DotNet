
using IrrigationWebSystem.ApplicationCore.DomainEntities;
using IrrigationWebSystem.ApplicationCore.Interfaces;
using IrrigationWebSystem.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees;
        }
    }
}

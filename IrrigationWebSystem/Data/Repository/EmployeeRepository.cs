
using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Employee GetEmployeeByEmpNumber(string empNumber)
        {
            return _context.Employees.FirstOrDefault(emp => emp.EmpNumber == empNumber);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees;
        }
    }
}

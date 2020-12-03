using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenkatCore.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = _appDbContext.Employees.Find(id);
            if(employee != null)
            {
                _appDbContext.Employees.Remove(employee);
                _appDbContext.SaveChanges();
            }

            return employee;
        }

        public Employee EditEmployee(Employee empChanges)
        {
            var employee = _appDbContext.Employees.Find(empChanges.Id);
            if(employee != null)
            {
                employee.Name = empChanges.Name;
                employee.Email = empChanges.Email;
                employee.Gender = empChanges.Gender;
                employee.DeptId = empChanges.DeptId;
                _appDbContext.SaveChanges();
            }

            return empChanges;
        }

        public Employee GetEmployee(int id)
        {
            var employee=_appDbContext.Employees.FirstOrDefault(emp => emp.Id == id);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            //return _appDbContext.Employees.ToList();

            var employees = from emp in _appDbContext.Employees.Include(dept => dept.Department)
                            select emp;

            return employees;

        }
    }
}

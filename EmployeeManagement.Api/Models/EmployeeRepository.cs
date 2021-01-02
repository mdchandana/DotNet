using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result= await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        //public async void DeleteEmployee(int employeeId)
        //{
        //    var result = await _appDbContext.Employees
        //                        .FirstOrDefaultAsync(emp => emp.EmployeeId == employeeId);
        //    if(result != null)
        //    {
        //        _appDbContext.Employees.Remove(result);
        //        await _appDbContext.SaveChangesAsync();
        //    }

        //}


        public async Task<Employee> DeleteEmployee(int employeeId)
        {
            var employeeToDelete = await _appDbContext.Employees
                                .FirstOrDefaultAsync(emp => emp.EmployeeId == employeeId);
            if (employeeToDelete != null)
            {
                _appDbContext.Employees.Remove(employeeToDelete);
                await _appDbContext.SaveChangesAsync();

                return employeeToDelete;
            }

            return null;
        }





        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await _appDbContext.Employees
                            .FirstOrDefaultAsync(emp => emp.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _appDbContext.Employees
                .FirstOrDefaultAsync(emp => emp.Email == email);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = _appDbContext.Employees;

            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name)
                          || e.LastName.Contains(name));
            }

            if(gender !=null)
            {
                query = query.Where(e => e.Gender == gender);
            }

            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var employeeToUpdate = await _appDbContext.Employees
                        .FirstOrDefaultAsync(emp => emp.EmployeeId == employee.EmployeeId);

            if(employeeToUpdate != null)
            {
                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.LastName = employee.LastName;
                employeeToUpdate.Email = employee.Email;
                employeeToUpdate.DateOfBrith = employee.DateOfBrith;
                employeeToUpdate.Gender = employee.Gender;
                employeeToUpdate.DepartmentId = employee.DepartmentId;
                employeeToUpdate.PhotoPath = employee.PhotoPath;

                await _appDbContext.SaveChangesAsync();
                return employeeToUpdate;
            }

            return null;
        }
    }
}

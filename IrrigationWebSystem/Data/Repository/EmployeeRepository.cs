
using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public Employee AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();

            return employee;
        }

        public Employee GetEmployeeByEmpId(int employeeId)
        {
            return _context.Employees.FirstOrDefault(emp => emp.EmployeeId == employeeId);
        }

        public Employee GetEmployeeByEmpNumber(string empNumber)
        {
            return _context.Employees
                    .Include(contact=>contact.EmployeeContacts)
                    .FirstOrDefault(emp => emp.EmpNumber == empNumber);
        }

        public IEnumerable<Employee> GetEmployeesByPositionId(int positionId)
        {
            return _context.Employees
                    .Include(p=> p.EmployeePosition)
                    .Where(Employee => Employee.EmployeePositionId == positionId);
        }


        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.Include(p => p.EmployeePosition);
        }

        public Employee UpdateEmployee(Employee employeeChangees)
        {
            var foundEmployee = _context.Employees.Find(employeeChangees.EmployeeId);
            if(foundEmployee !=null)
            {
                foundEmployee.EmpNumber = employeeChangees.EmpNumber;
                foundEmployee.Nic = employeeChangees.Nic;
                foundEmployee.PersonalFileNumber = employeeChangees.PersonalFileNumber;
                foundEmployee.NameWithInitial = employeeChangees.NameWithInitial;
                foundEmployee.FullName = employeeChangees.FullName;
                foundEmployee.SurName = employeeChangees.SurName;
                foundEmployee.EmployeePositionId = employeeChangees.EmployeePositionId;
                foundEmployee.Gender = employeeChangees.Gender;
                foundEmployee.CivilStatus = employeeChangees.CivilStatus;
                foundEmployee.Address = employeeChangees.Address;
                //foundEmployee.EmployeeContacts.ToList()[0].ToString(),
                foundEmployee.Email = employeeChangees.Email;
                foundEmployee.DateOfBirth = employeeChangees.DateOfBirth;
                foundEmployee.AppointmentDate = employeeChangees.AppointmentDate;
                foundEmployee.BasicSalary = employeeChangees.BasicSalary;
                foundEmployee.CurrentlyWorkingStatus = employeeChangees.CurrentlyWorkingStatus;
                foundEmployee.ClassMnGrade = employeeChangees.ClassMnGrade;

                _context.SaveChanges();
                return foundEmployee;
            }

            return null;
        }
    }
}

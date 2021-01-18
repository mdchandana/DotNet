using IrrigationWebSystem.Models.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeByEmpId(int employeeId);
        Employee GetEmployeeByEmpNumber(string empNumber);
        Employee GetEmployeeByPositionId(int positionId);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
    }
}

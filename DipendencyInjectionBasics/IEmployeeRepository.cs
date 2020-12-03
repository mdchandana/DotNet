using System;
using System.Collections.Generic;
using System.Text;

namespace DipendencyInjectionBasics
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee AddEmployee(Employee employee);
    }   

}

using System;
using System.Collections.Generic;
using System.Text;

namespace DipendencyInjectionBasics
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}

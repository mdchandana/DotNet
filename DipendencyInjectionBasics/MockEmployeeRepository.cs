using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipendencyInjectionBasics
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            //empty _employeeList
            _employeeList = new List<Employee>();
            

            //_employeeList = new List<Employee>()
            //{
            //    new Employee(){ Id=2001,Name="Sidath"},
            //    new Employee(){ Id=2016,Name="Chandana"}
            //};
        }

        public Employee AddEmployee(Employee employee)
        {
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {

            //var container = Startup.ConfigureService();
            //var mockRepoService = container.GetRequiredService<IEmployeeRepository>();

            return _employeeList;
        }
    }
}

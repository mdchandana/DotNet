using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenkatCore.Models
{

 /*
 * we use IEmployeeRepository to Dependency Injection,
 *If we don't use Dependency Injection in our application, It is difficult to change and maintain our application and -
 * Unit Testing also become very difficult...
 * Throw out our application we will be programming againts this Interface IEmployeeRepository and not againts any concrette Implementation -
 * such as this MockEmployeeRepository , this allows us to Dependency Injection which intern allows our application 
 * to be more flexible and easily Unit Testible.....
 */


    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);
        Employee EditEmployee(Employee empChanges);
        Employee DeleteEmployee(int id);

    }
}

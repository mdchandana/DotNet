using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DipendencyInjectionBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //WORKED----------------------------------------------------------------
            //=====Access Dependency Injection container and Resolving Dependencies...
            var container = Startup.ConfigureService();
            var mockRepoService = container.GetRequiredService<IEmployeeRepository>();
            //---------------------------------------------------------------------





            var selection = "1";

            while (selection != "0")
            {

                Console.WriteLine("Enter selection : '0' for Terminate");
                Console.WriteLine("Enter selection : '1' for View Employees");
                Console.WriteLine("Enter selection : '2' for Add Employees");

                selection = Console.ReadLine();

                if (!string.IsNullOrEmpty(selection))
                {
                    if (selection == "1")
                    {
                        DisplayEmployees(mockRepoService);


                    }
                    if (selection == "2")
                    {
                        AddEmployee(mockRepoService);
                        DisplayEmployees(mockRepoService);
                    }
                }
                else
                {
                    throw new Exception("Invalid selection");
                    //throw new ArgumentException("Invalid selection");
                }                
            }

            Console.WriteLine("Terminating Program..");
            Console.ReadKey();

        }



        private static void DisplayEmployees(IEmployeeRepository mockRepoService)
        {
            Console.WriteLine("Displaying Records..");

            if (!(mockRepoService.GetEmployees().ToList().Count > 0))
            {
                Console.WriteLine("No Employees to display....");
            }
            else
            {               

                foreach (var emp in mockRepoService.GetEmployees())
                {
                    Console.WriteLine($"EmpId :{emp.Id} \t EmpName :{emp.Name}");
                }

            }
            
        }




        private static void AddEmployee(IEmployeeRepository mockRepoService)
        {            

            Console.Write("Enter Employee Id :");
            var empId = Convert.ToInt32(Console.ReadLine());           
            Console.Write("Enter Employee Name :");
            var empName = Console.ReadLine();


            if(!(string.IsNullOrEmpty(empId.ToString()) || string.IsNullOrEmpty(empName)))
            {
                var employee = new Employee();
                employee.Id = empId;
                employee.Name = empName;
                mockRepoService.AddEmployee(employee);
                Console.WriteLine("Employee Record Added");
            }
            else
            {
                throw new Exception("Invalid Employee Details..");
            }
        }
    }
}

using Microsoft.AspNetCore.Components;
using PieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopHRM.App.Pages
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public string EmpNumber { get; set; }

                
        public Employee Employee { get; set; } = new Employee();
       


        protected override Task OnInitializedAsync()
        {
            loadEmployees();

            //load employee by parameter
            Employee = Employees.Where(emp => emp.EmpNumber == EmpNumber).FirstOrDefault();


            return base.OnInitializedAsync();
        }




        public IEnumerable<Employee> Employees { get; set; }

        void loadEmployees()
        {
            Employees = new List<Employee>()
            {
                new Employee()
                {
                    EmpNumber="538",
                    FullName="Chandana Priyantha",
                    ImageName="/Photoes/538.jpg"
                },
                new Employee()
                {
                    EmpNumber="510",
                    FullName="Sidatha",
                     ImageName="/Photoes/510.jpg"
                },
                new Employee()
                {
                    EmpNumber="511",
                    FullName="Yasiru jayawardana",
                     ImageName="/Photoes/511.jpg"
                }
            };
        }
    }
}

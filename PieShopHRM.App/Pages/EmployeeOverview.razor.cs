using PieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {

        
        public List<Employee> Employees { get; set; }

        


        protected override Task OnInitializedAsync()
        {
            loadEmployees();

            return base.OnInitializedAsync();
        }


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

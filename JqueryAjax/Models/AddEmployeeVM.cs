using JqueryAjax.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Models
{
    public class AddEmployeeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [Range(20,60,ErrorMessage ="Age should between 20 - 60")]
        public int Age { get; set; }

        
        public double Salary { get; set; }

        //--------------FOR HANDLE POSITIONS-----------------------------------------------------
        public int DepartmentId { get; set; }  //this is just for keep deptId From Department selectlist
        public SelectList  EmployeeDepartments { get; set; }
        //-----------------------------------------------------------------------------------------




    }

    //<script src = "~/Scripts/jquery-2.1.1.js" ></ script >
    //<script src="~/Scripts/jquery.validate.min.js"></script>  
    //<script src = "~/Scripts/jquery.validate.unobtrusive.min.js" ></ script

    //[Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
    //[Range(0, float.MaxValue, ErrorMessage = "Please enter valid float Number")]
    //[Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]

    //[Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
    //public int Age { get; set; }

    //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
    //public System.DateTime? HireDate { get; set; }


    //[Required(ErrorMessage = "Age is Required")]
    //[Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
    //public int Age { get; set; }


    //[Range(1.00, 100.00, ErrorMessage = "Please enter a Amount between 1.00 and 100.00")]
    //public decimal? Amount { get; set; }
}

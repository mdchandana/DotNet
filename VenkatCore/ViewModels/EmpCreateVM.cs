using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VenkatCore.Models;


namespace VenkatCore.ViewModels
{
    public class EmpCreateVM
    {
        [Required(ErrorMessage = "Name cannot be Empty..")]
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        public int DeptId { get; set; }        
    }
}

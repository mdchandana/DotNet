using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }

        
        [Required]
        //[Remote(controller: "User", action: "IsUserNameAvailable")]  ///WORKED
        //[Remote("IsUserNameAvailable", "User", ErrorMessage = "User already exists")]  ///WORKED
        [Remote(controller: "User", action: "IsUserNameAvailable", ErrorMessage = "This UserName already Taken")]  ///WORKED
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

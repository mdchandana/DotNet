using JqueryAjax.Models;
using JqueryAjax.Models.DomainEntities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("UserView");
        }

        [HttpPost]
        public JsonResult CreateUser(User user)
        {
            var jsonObject = new { status = "Added", addedObject = user };

            return Json(jsonObject);
        }


        [AcceptVerbs("Get", "Post")]
        public JsonResult IsUserNameAvailable(string UserName)
        {
            User user = new User();

            //here status true mean , not displaying a validation message
            bool status = true;

            ////Worked.. status = false mean userName is not available, alrady taken
            //var foundUser = user.GetAllUsers().Find(u => u.UserName == UserName);
            //if (foundUser != null)
            //    status = false;

            ////Worked.. status = false mean userName is not available, alrady taken
            //userName already taken
            //client side validation displaying
            if (user.GetAllUsers().Any(u => u.UserName == UserName))
            {
                status = false;
            }



            return Json(status);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return Content("Home-Index");
        }


        //--------Attribute Routing-------------------------
        //url : http://localhost:60459/home/message
        [Route("/home/Message")]
        public IActionResult Message()
        {
            return Content($"Home-Message method called");
        }

        //--------Attribute Routing-------------------------
        //url : http://localhost:60459/home/message2/chandana
        //url : http://localhost:60459/home/message2?name=chandana
        [Route("/home/Message2/{name?}")]
        public IActionResult Message2(string name)
        {
            return Content($"Home-Message2 method called :{name}");   
        }     
        



    }
}
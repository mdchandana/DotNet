using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebGentle.Controllers
{
    public class HomeController : Controller
    {
   
        
        //url : /home/getAllBooks       
        public IActionResult GetAllBooks()
        {
            return Content("Home-GetAllBooks Called");
        }



        //url : /home/GetBookById/2016
        //url : /home/GetBookById?2016        
        public IActionResult GetBookById(int id)
        {
            return Content($"Home-GetBookById called :{id}");
        }


        //url       : /home/GetBookByName?name=chandana    
        //NOT WORK : /home/GetBookByName/chandana
        public IActionResult GetBookByName(string name)
        {
            return Content($"Home-GetBookByName called :{name}");
        }

        //WORK : /home/GetBookByGenre/action
        //WORK : /home/GetBookByGenre?genre=action
        [Route("/home/GetBookByGenre/{genre?}")]
        public IActionResult GetBookByGenre(string genre)
        {
            return Content($"Home-GetBookByGenre called :{genre}");
        }




        //url : /home/GetBookByNameAuthor/name1/author1
        //url : /home/GetBookByNameAuthor?name=name1&author=author1
        [Route("/home/GetBookByNameAuthor/{name?}/{author?}")]
        public IActionResult GetBookByNameAuthor(string name, string author)
        {
            return Content($"Home-GetBookByNameAuthor called Name:{name} and Author:{author}");
        }



    }
}
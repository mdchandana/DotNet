using ShoppingCartBasicsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartBasicsMVC.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext context = new AppDbContext();

        // GET: Product
        public ActionResult Index()
        {
            return View(context.Products.ToList());
        }
    }
}
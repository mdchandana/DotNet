using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreBasics.BLL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreTestingWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerBLL _customerBLL;

        public HomeController(ICustomerBLL customerBLL)
        {
            _customerBLL = customerBLL;
        }
        public IActionResult Index()
        {
            var customers = _customerBLL.GetCustomers();
            return View(customers);
        }
    }
}
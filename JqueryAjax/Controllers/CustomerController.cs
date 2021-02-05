using JqueryAjax.Context;
using JqueryAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Controllers
{
    public class CustomerController : Controller
    {
        private AppDbContext _context;

        public CustomerController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }


        public IActionResult Index()
        {
            return View("AllCustomersView");
        }


        [HttpGet]
        public JsonResult GetCustomers()
        {
            var customerList = _context.Customers
                                .ToList();

            return Json(new { data = customerList });
        }

        [HttpPost]
        public JsonResult SaveCustomer(Customer customer)
        {

            if (customer.Id > 0) //edit
            {
                var customerFound = _context.Customers.Find(customer.Id);
                if (customer != null)
                {
                    customerFound.Name = customer.Name;
                    customerFound.Address = customer.Address;
                    customerFound.Contact = customer.Contact;
                    customerFound.DateOfBirth = customer.DateOfBirth;
                    customerFound.CreatedTime = customer.CreatedTime;
                }
            }
            else  //new
            {
                _context.Customers.Add(customer);
            }
            
            _context.SaveChanges();

            return Json(new { status = true });
        }




        [HttpPost]
        public JsonResult DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);

            if (customer != null)
            {
                _context.Remove(customer);
                _context.SaveChanges();
            }


            return Json(new { status = true });
        }

    }
}

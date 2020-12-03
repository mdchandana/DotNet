using EFCoreBasics.BLL.Interface;
using EFCoreBasics.DAL;
using EFCoreBasics.DAL.Entities;
using EFCoreBasics.DAL.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;



namespace EFCoreBasics
{
    class Program
    {
        static void Main(string[] args)
        {


            //using (var context = new AppDbContext())
            //{
            //    var customers = context.Customers.ToList();

            //    Console.WriteLine("Displaying Customers...");

            //    foreach (var customer in customers)
            //    {
            //        Console.WriteLine(customer.Name);
            //    }
            //}
            
          
            var container = Startup.ConfigureService();

            ////WORKED  COMMENTED
            //var appDbContext = container.GetRequiredService<AppDbContext>();
            //var customers = appDbContext.Customers.ToList();
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"CustomerID :{customer.Id} \t CustomerName :{customer.Name}");
            //}
            //Console.ReadLine();


            //WORKED
            //var customerRepository = container.GetRequiredService<ICustomerRepository>();
            //var customers = customerRepository.GetCustomers();
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"CustomerID :{customer.Id} \t CustomerName :{customer.Name}");
            //}
            //Console.ReadLine();


            //Calling BLL without directly calling DAL
            var customerBLL = container.GetRequiredService<ICustomerBLL>();
            var customers = customerBLL.GetCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine($"CustomerID :{customer.Id} \t CustomerName :{customer.Name}");
            }
            Console.ReadLine();

        }
    }
}

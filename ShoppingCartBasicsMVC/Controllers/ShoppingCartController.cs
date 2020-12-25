using ShoppingCartBasicsMVC.Models;
using ShoppingCartBasicsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartBasicsMVC.Controllers
{
    public class ShoppingCartController : Controller
    {

        AppDbContext context = null;
        List<CartItem> cartItemList = null;

        public ShoppingCartController()
        {
            context = new AppDbContext();
            cartItemList = new List<CartItem>();
        }

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddOrderItem(int id)
        {
            CartItem cartItem = null;

            if (Session["cart"] == null)
            {
                var orderProduct = context.Products.Find(id);

                cartItem = new CartItem(orderProduct, 1);  //adding qty 1
                cartItemList.Add(cartItem);
                Session["cart"] = cartItemList;

            }
            else
            {
                cartItemList = (List<CartItem>)Session["cart"];

                //check whether specific product already in the cart, if it is  - 
                //, we are not adding again, just incrementing the qty...
                var foundProductInCart = cartItemList.FirstOrDefault(x => x.Product.Id == id);
                if (foundProductInCart != null)
                {
                    foundProductInCart.Qty++; //increment qty by anotheer
                }
                else
                {
                    //we are adding a product that is not in the cart already..
                    var product = context.Products.Find(id);
                    cartItem = new CartItem(product, 1);     //adding qty 1

                    cartItemList.Add(cartItem);
                    Session["cart"] = cartItemList;
                }
            }



            //returning currentCartItemList to view...
            cartItemList = null;
            cartItemList = (List<CartItem>)Session["cart"];

            return View("Cart", cartItemList);
        }




        public ActionResult RemoveOrderItem(int id)
        {
            cartItemList = (List<CartItem>)Session["cart"];
            var cartItemToRemove = cartItemList.Find(p => p.Product.Id == id);

            if (cartItemToRemove != null)
            {
                //we have to check,whether this cartItem Qty is more than 1,if it is we just only decrement the qty....
                //if qty > 1 , we are not remove the cartItem, we just decrement the qty..
                //if qty == 1 , we can remove the cartItem
                if (cartItemToRemove.Qty == 1)
                {
                    cartItemList.Remove(cartItemToRemove);
                }
                else
                {
                    cartItemToRemove.Qty--;
                }

                Session["cart"] = cartItemList;
            }

            return View("Cart", cartItemList);
        }




        public ActionResult Checkout()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SaveOrder(Customer customer)
        {

            int customerId;   //for newly created customerId
            int orderId;      //for newly created OrderId

            //Saving Customer-------------------
            context.Customers.Add(customer);
            context.SaveChanges();
            customerId = customer.Id;   //for newly created customerId




            //Saving order----------------------
            var order = new Order()
            {
                CustomerId = customerId,
                OrderDate = DateTime.Today
            };

            context.Orders.Add(order);
            context.SaveChanges();
            orderId = order.Id;         //for newly created OrderId




            //saving orderDetails
            cartItemList = (List<CartItem>)Session["Cart"];

            foreach (var cartItem in cartItemList)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderId = orderId,
                    ProductId = cartItem.Product.Id,
                    Qty = cartItem.Qty
                };

                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }

            //remove session
            Session.Remove("cart");


            return View("SaveOrderCompleted");
        }



    }
}
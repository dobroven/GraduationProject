using AspNetCoreApp.Data.Interfaces;
using AspNetCoreApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrders Orders;
        private readonly RestaurantCart restaurantCart;

        public OrderController(IOrders Orders, RestaurantCart restaurantCart)
        {
            this.Orders = Orders;
            this.restaurantCart = restaurantCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            restaurantCart.ListRestaurantItems = restaurantCart.GetRestaurantItems();

            if(restaurantCart.ListRestaurantItems.Count == 0)
            {
                ModelState.AddModelError("", "Блюда не выбраны!");
            }

            if(ModelState.IsValid)
            {
                Orders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}

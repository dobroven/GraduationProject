using AspNetCoreApp.Data.Interfaces;
using AspNetCoreApp.Data.Models;
using AspNetCoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Controllers
{
    public class RestaurantCartController : Controller
    {
        private readonly IDishes dishRep;
        private readonly RestaurantCart restaurantCart;

        public RestaurantCartController(IDishes dishRep, RestaurantCart restaurantCart)
        {
            this.dishRep = dishRep;
            this.restaurantCart = restaurantCart;
        }

        public ViewResult Index()
        {
            var items = restaurantCart.GetRestaurantItems();
            restaurantCart.ListRestaurantItems = items;
            var obj = new RestaurantCartViewModel
            {
                restaurantCart = restaurantCart
            };
            return View(obj);
        }

        public RedirectToActionResult AddToCart (int id)
        {
            var item = dishRep.Dishes.FirstOrDefault(i => i.Id == id);
            if (item != null)
                restaurantCart.AddToCart(item);
            return RedirectToAction("Index");
        }
    }
}
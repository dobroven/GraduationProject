using AspNetCoreApp.Data.Interfaces;
using AspNetCoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Repository
{
    public class DishRepository : IDishes
    {
        private readonly RestaurantDBContext restaurantDBContext;

        public DishRepository(RestaurantDBContext restaurantDBContext)
        {
            this.restaurantDBContext = restaurantDBContext;
        }

        public IEnumerable<Dish> Dishes => restaurantDBContext.Dish.Include(c => c.Category);

        public IEnumerable<Dish> GetAvailableDishes => restaurantDBContext.Dish.Where(d => d.Available).Include(c => c.Category);

        public Dish GetObjectDish(int DishId) => restaurantDBContext.Dish.FirstOrDefault(o => o.Id == DishId);
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Models
{
    public class RestaurantCart
    {
        private readonly RestaurantDBContext restaurantDBContext;

        public RestaurantCart(RestaurantDBContext restaurantDBContext)
        {
            this.restaurantDBContext = restaurantDBContext;
        }

        public string RestaurantCartId { get; set; }

        public List<RestaurantCartItem> ListRestaurantItems { get; set; }

        public static RestaurantCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<RestaurantDBContext>();
            string restaurantCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", restaurantCartId);
            return new RestaurantCart(context) { RestaurantCartId = restaurantCartId };
        }

        public void AddToCart(Dish dish)
        {
            restaurantDBContext.RestaurantCartItem.Add(new RestaurantCartItem
            {
                RestaurantCartId = RestaurantCartId,
                Dish = dish,
                Price = dish.Price
            });

            restaurantDBContext.SaveChanges();
        }

        public List<RestaurantCartItem> GetRestaurantItems()
        {
            return restaurantDBContext.RestaurantCartItem.Where(c => c.RestaurantCartId == RestaurantCartId).Include(s => s.Dish).ToList();
        }
    }
}

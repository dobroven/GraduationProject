using AspNetCoreApp.Data.Interfaces;
using AspNetCoreApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Repository
{
    public class OrderRepository : IOrders
    {
        private readonly RestaurantDBContext restaurantDBContext;
        private readonly RestaurantCart restaurantCart;

        public OrderRepository(RestaurantDBContext restaurantDBContext, RestaurantCart restaurantCart)
        {
            this.restaurantDBContext = restaurantDBContext;
            this.restaurantCart = restaurantCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            restaurantDBContext.Order.Add(order);

            var items = restaurantCart.ListRestaurantItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    DishId = el.Dish.Id,
                    OrderId = order.Id,
                    Price = el.Dish.Price
                };
                restaurantDBContext.OrderDetail.Add(orderDetail);
            }
            restaurantDBContext.SaveChanges();
        }
    }
}

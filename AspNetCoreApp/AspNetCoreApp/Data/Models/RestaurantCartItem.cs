using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Models
{
    public class RestaurantCartItem
    {
        public int Id { get; set; }
        public Dish Dish { get; set; }
        public int Price { get; set; }

        public string RestaurantCartId { get; set; }
    }
}

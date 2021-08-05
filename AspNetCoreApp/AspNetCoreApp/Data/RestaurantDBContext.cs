using AspNetCoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext(DbContextOptions<RestaurantDBContext> Options) : base(Options)
        {

        }

        public DbSet<Dish> Dish { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<RestaurantCartItem> RestaurantCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}

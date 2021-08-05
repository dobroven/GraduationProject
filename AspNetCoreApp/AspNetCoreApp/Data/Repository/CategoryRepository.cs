using AspNetCoreApp.Data.Interfaces;
using AspNetCoreApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly RestaurantDBContext restaurantDBContext;

        public CategoryRepository(RestaurantDBContext restaurantDBContext)
        {
            this.restaurantDBContext = restaurantDBContext;
        }

        public IEnumerable<Category> AllCategories => restaurantDBContext.Category;
    }
}

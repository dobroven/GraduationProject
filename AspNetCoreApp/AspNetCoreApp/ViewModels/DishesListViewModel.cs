using AspNetCoreApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.ViewModels
{
    public class DishesListViewModel
    {
        public IEnumerable<Dish> AllDishes { get; set; }
        public string CurrentCategory { get; set; }
    }
}

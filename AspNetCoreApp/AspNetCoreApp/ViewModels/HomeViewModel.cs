using AspNetCoreApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Dish> AvailableDishes { get; set; }
    }
}

using AspNetCoreApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Interfaces
{
    public interface IDishes
    {
        IEnumerable<Dish> Dishes { get; }
        IEnumerable<Dish> GetAvailableDishes { get; }
        Dish GetObjectDish(int DishId);
    }
}

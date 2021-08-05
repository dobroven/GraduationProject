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
    public class DishesController : Controller
    {
        private readonly IDishes _Dishes;
        private readonly ICategory _Category;

        public DishesController(IDishes Dishes, ICategory Category)
        {
            _Dishes = Dishes;
            _Category = Category;
        }

        [Route("Dishes/List")]
        [Route("Dishes/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Dish> dishes = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                dishes = _Dishes.Dishes.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("pizza", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _Dishes.Dishes.Where(i => i.Category.Name.Equals("Пицца")).OrderBy(i => i.Id);
                    currCategory = "Пицца";
                }
                else if (string.Equals("rolls", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _Dishes.Dishes.Where(i => i.Category.Name.Equals("Роллы")).OrderBy(i => i.Id);
                    currCategory = "Роллы";
                }
                else if (string.Equals("desserts", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _Dishes.Dishes.Where(i => i.Category.Name.Equals("Десерты")).OrderBy(i => i.Id);
                    currCategory = "Десерты";
                }
                else if (string.Equals("drinks", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _Dishes.Dishes.Where(i => i.Category.Name.Equals("Напитки")).OrderBy(i => i.Id);
                    currCategory = "Напитки";
                }
                else if (string.Equals("snacks", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _Dishes.Dishes.Where(i => i.Category.Name.Equals("Закуски")).OrderBy(i => i.Id);
                    currCategory = "Закуски";
                }
                else if (string.Equals("salads", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _Dishes.Dishes.Where(i => i.Category.Name.Equals("Салаты")).OrderBy(i => i.Id);
                    currCategory = "Салаты";
                }
            }

            var DishObj = new DishesListViewModel
            {
                AllDishes = dishes,
                CurrentCategory = currCategory
            };
            

            return View(DishObj);
        }
    }
}

using AspNetCoreApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreApp.ViewModels;

namespace AspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDishes dishRep;

        public HomeController(IDishes dishRep)
        {
            this.dishRep = dishRep;
        }

        public ViewResult Index()
        {
            var HomeDishes = new HomeViewModel
            {
                AvailableDishes = dishRep.GetAvailableDishes
            };
            return View(HomeDishes);
        }
    }
}

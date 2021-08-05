using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Desc { set; get; }
        List<Dish> Dishes { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Models
{
    public class Dish
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string ShortDesc { set; get; }
        public string LongDesc { set; get; }
        public string Image { set; get; }
        public ushort Price { set; get; }
        public string CaloricContent { set; get; }
        public string Weight { set; get; }
        public bool Available { set; get; }
        public int CategoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}

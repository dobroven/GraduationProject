using AspNetCoreApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data
{
    public class DBObjects
    {
        public static void Initial(RestaurantDBContext Context)
        {
            
            if (!Context.Category.Any())
                Context.Category.AddRange(Categories.Select(c => c.Value));

            if (!Context.Dish.Any())
            {
                Context.AddRange(
                    new Dish
                    {
                        Name = "Ветчина и грибы",
                        ShortDesc = "Ветчина, грибы шампиньоны, сыр моцарелла, соус томатный. К пицце подается фирменный томатный соус.",
                        LongDesc = "",
                        Image = "/img/vetchgrib.png",
                        Price = 390,
                        CaloricContent = "129 ккал/100 г",
                        Weight = "350 г",
                        Available = true,
                        Category = Categories["Пицца"]
                    },
                    new Dish
                    {
                        Name = "Дзен",
                        ShortDesc = "Мидии, сыр в слайсах, лук зеленый, соус чесночный, соус унаги, белый кунжут жареный.",
                        LongDesc = "",
                        Image = "/img/dzen.png",
                        Price = 219,
                        CaloricContent = "225 ккал/100 г",
                        Weight = "190 г",
                        Available = true,
                        Category = Categories["Роллы"]
                    },
                    new Dish
                    {
                        Name = "Пепперони",
                        ShortDesc = "Пепперони, сыр моцарелла, соус томатный. К пицце подается фирменный томатный соус.",
                        LongDesc = "",
                        Image = "/img/pep.jpg",
                        Price = 240,
                        CaloricContent = "179 ккал/100 г",
                        Weight = "450 г",
                        Available = true,
                        Category = Categories["Пицца"]
                    },
                    new Dish
                    {
                        Name = "Маргарита",
                        ShortDesc = "Помидор, петрушка, сыр моцарелла, соус томатный. К пицце подается фирменный томатный соус.",
                        LongDesc = "",
                        Image = "/img/mar.png",
                        Price = 368,
                        CaloricContent = "102 ккал/100 г",
                        Weight = "340 г",
                        Available = true,
                        Category = Categories["Пицца"]
                    },
                    new Dish
                    {
                        Name = "Мясная",
                        ShortDesc = "Ветчина, бекон сырокопченый, колбаса полукопченая, сыр моцарелла, соус томатный. К пицце подается фирменный томатный соус.",
                        LongDesc = "",
                        Image = "/img/myas.png",
                        Price = 670,
                        CaloricContent = "221 ккал/100 г",
                        Weight = "650 г",
                        Available = true,
                        Category = Categories["Пицца"]
                    },
                    new Dish
                    {
                        Name = "Рубин",
                        ShortDesc = "Масляная рыба холодного копчения, сыр сливочный, икра тобико красная, лук зеленый, соус чесночный, соус унаги, белый кунжут.",
                        LongDesc = "",
                        Image = "/img/rubin.png",
                        Price = 640,
                        CaloricContent = "151 ккал/100 г",
                        Weight = "320 г",
                        Available = true,
                        Category = Categories["Роллы"]
                    },
                    new Dish
                    {
                        Name = "Сила духа",
                        ShortDesc = "Тунец, огурец, лук зеленый, укроп, соус спайси, соус унаги, белый кунжут.",
                        LongDesc = "",
                        Image = "/img/sila.png",
                        Price = 350,
                        CaloricContent = "89 ккал/100 г",
                        Weight = "230 г",
                        Available = true,
                        Category = Categories["Роллы"]
                    }
                );
            }
            Context.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var List = new Category[]
                    {
                        new Category { Name = "Пицца",
                        Desc = "Закажите сытную и горячую пиццу в Белгороде с доставкой на дом или офис ;)"},
                        new Category { Name = "Роллы",
                        Desc = "У вас прекрасная возможность заказать роллы с доставкой по городу Белгород. Мы начинаем готовить только после получения вашего заказа!"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category element in List)
                        category.Add(element.Name, element);
                }
                return category;
            }
        }
    }
}

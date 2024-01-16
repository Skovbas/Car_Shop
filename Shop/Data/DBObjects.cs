using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any()){
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Fast auto",
                        longDesc = "A beautiful, fast and very quiet car from the Tesla company",
                        img = "/img/tesla.jpeg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electric"]
                    },
                    new Car
                    {
                        name = "BMW 3",
                        shortDesc = "Fast auto",
                        longDesc = "A comfortable and fast car for every day",
                        img = "/img/bmw.jpeg",
                        price = 26000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Disel"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Quiet and calm",
                        longDesc = "A comfortable car for every day",
                        img = "/img/ford.jpg",
                        price = 19000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Disel"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                        new Category { categoryName = "Electric", desc = "Сучасний вид транспорта" },
                        new Category { categoryName = "Disel", desc = "Машини з двигуном внутрішнього згорання" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}

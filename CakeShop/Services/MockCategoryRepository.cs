using CakeShop.Interfaces;
using CakeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Services
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategorys 
        {
            get
            {
                return new List<Category>()
                {
                    new Category{ CategoryId=1, CategoryName="Sweet Cake", Description ="Sweet Cake from Honey"},
                    new Category{ CategoryId=2, CategoryName="Fruit Cake", Description ="Cake from fruit"},
                    new Category{ CategoryId=3, CategoryName="Seasonal Cake", Description ="Cake from Seasonal"},
                     new Category{ CategoryId=3, CategoryName="Chocolate Cake", Description ="Cake from Chocolate"}
                };
            }
        }
    }
}

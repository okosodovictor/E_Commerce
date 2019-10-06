using CakeShop.Interfaces;
using CakeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext _Context;

        public CategoryRepository(AppDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Category> AllCategorys => _Context.Categories;
    }
}

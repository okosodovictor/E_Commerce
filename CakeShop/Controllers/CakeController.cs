using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeShop.Interfaces;
using CakeShop.Models;
using CakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeService _cakeService;
        private readonly ICategoryRepository _repo;
        public CakeController(ICakeService cakeService, ICategoryRepository repo)
        {
            _cakeService = cakeService;
            _repo = repo;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Cake> cakes;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cakes = _cakeService.GetAllCakes().OrderBy(p => p.CakeId);
                currentCategory = "All cakes";
            }
            else
            {
                cakes = _cakeService.GetAllCakes().Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.CakeId);
                currentCategory = _repo.AllCategorys.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CakeListViewModel
            {
                Cakes = cakes,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
           var cake = _cakeService.GetCakeById(id);
            if (cake == null) return NotFound();

            return View(cake);
        }
    }
}
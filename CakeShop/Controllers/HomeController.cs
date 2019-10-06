using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeShop.Interfaces;
using CakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeService _service;

        public HomeController(ICakeService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                cakeOftheWeek = _service.GetCakesOfTheWeek()
            };

            return View(homeViewModel);
        }
    }
}
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
    public class ShoppingCartController : Controller
    {
        private readonly ICakeService _service;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICakeService service, ShoppingCart shoppingCart)
        {
            _service = service;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var slectedCake = _service.GetAllCakes().FirstOrDefault(p => p.CakeId == id);

            if (slectedCake != null)
            {
                _shoppingCart.AddToCart(slectedCake, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int cakeId)
        {
            var slectedCake = _service.GetAllCakes().FirstOrDefault(p => p.CakeId == cakeId);

            if (slectedCake != null)
            {
                _shoppingCart.RemoveFromCart(slectedCake);
            }

            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeShop.Models;

namespace CakeShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public decimal ShoppingCartTotal;
        public ShoppingCart ShoppingCart { get; internal set; }
    }
}

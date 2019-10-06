using CakeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Interfaces
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
    }
}

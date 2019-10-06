using CakeShop.Interfaces;
using CakeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;

       public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public void CreateOrder(Order order)
        {
            _repo.CreateOrder(order);
        }
    }
}

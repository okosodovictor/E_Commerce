using CakeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Interfaces
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> AllCakes { get; }
        IEnumerable<Cake> CakesOfTheWeek();
        Cake GetCakeById(int id);
    }
}

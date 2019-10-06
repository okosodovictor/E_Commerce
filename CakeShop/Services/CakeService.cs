using CakeShop.Interfaces;
using CakeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Services
{
    public class CakeService: ICakeService
    {
        private readonly ICakeRepository _cakeRepository;

        public CakeService(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public IEnumerable<Cake> GetAllCakes()
        {
            return _cakeRepository.AllCakes;
        }

        public Cake GetCakeById(int id)
        {
            return _cakeRepository.GetCakeById(id);
        }

        public IEnumerable<Cake> GetCakesOfTheWeek()
        {
            return _cakeRepository.CakesOfTheWeek();
        }
    }
}

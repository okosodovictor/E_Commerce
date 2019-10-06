using CakeShop.Interfaces;
using CakeShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Repositories
{
    public class CakeRepository: ICakeRepository
    {
        private readonly AppDbContext _context;
        public CakeRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cake> AllCakes
        {
            get
            {
                return _context.Cakes.Include(c => c.Category);
            }
        }

        public IEnumerable<Cake> CakesOfTheWeek()
        {
            return _context.Cakes.Include(c => c.Category).Where(x => x.IsCakeOftheWeek);
        }

        public Cake GetCakeById(int id)
        {
            return _context.Cakes.Include(c => c.Category).FirstOrDefault(x => x.CakeId==id);
        }
    }
}

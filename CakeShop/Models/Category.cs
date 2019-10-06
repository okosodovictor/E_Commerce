using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Cake> cakes { get; set; }

        public Category()
        {
            cakes = new HashSet<Cake>();
        }
    }
}

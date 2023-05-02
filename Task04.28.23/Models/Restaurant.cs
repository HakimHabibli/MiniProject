using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04._28._23.Models
{
    public class Restaurant:BaseEntity
    {
        public Restaurant(string name) : base(name)
        {
        }

        public Restaurant()
        {
        }

        public List<Product> Products = new List<Product>() ;

    }
}

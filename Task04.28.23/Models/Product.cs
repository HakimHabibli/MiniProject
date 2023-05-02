using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04._28._23.Models
{
    public class Product:BaseEntity
    {
        public Product(string name) : base(name)
        {
        }

        public Product[] Amount { get; set; } = { };

    }
}

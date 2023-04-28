using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04._28._23.Models
{
    internal class Product
    {
        public Product()
        {
            _id++;
            Id = _id;
        }
        public Product(string name):this()
        {
            
            Name = name;
        }

        static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

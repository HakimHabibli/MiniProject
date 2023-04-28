using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04._28._23.Models
{
    internal class Restaurant
    {
        
        static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Product[] Products { get; set; } = { };
        public Restaurant()
        {
            _id++;
            Id = _id;
        }
        public Restaurant(string name):this() 
        {
            name = Name;
        }
    }
}

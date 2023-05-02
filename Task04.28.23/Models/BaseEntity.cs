using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04._28._23.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BaseEntity()
        {

        }
        public BaseEntity(string name) : this()
        {
            Name = name;
        }
    }
}

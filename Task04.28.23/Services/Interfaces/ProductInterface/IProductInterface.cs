using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task04._28._23.Models;

namespace Task04._28._23.Services.Interfaces.ProductInterface
{
    internal interface IProductInterface
    {
        public void Create(string name);
        public void Delete(string name);
        public void Update(string name);
        public Product GetById(int id);
    }
}

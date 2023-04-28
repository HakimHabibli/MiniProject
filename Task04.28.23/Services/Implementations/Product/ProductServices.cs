using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task04._28._23.Services.Interfaces.ProductInterface;

namespace Task04._28._23.Services.Implementations.Product
{
    internal class ProductServices : IProductInterface
    {
        Models.Product[] products = new Models.Product[0]; 
        public void Create(string name)
        {
            Array.Resize(ref products, products.Length + 1);
            Models.Product product = new Models.Product(name);
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public Models.Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(string name)
        {
            throw new NotImplementedException();
        }
    }
}

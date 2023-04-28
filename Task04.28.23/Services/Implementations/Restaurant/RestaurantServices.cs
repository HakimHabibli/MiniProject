using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task04._28._23.Services.Interfaces.RestaurantInterface;

namespace Task04._28._23.Services.Implementations.Restaurant
{
    internal class RestaurantServices : IRestaurantServices
    {
        Models.Restaurant[] restaurants = new Models.Restaurant[0];
        public void Create(string name)
        {
            Array.Resize(ref restaurants, restaurants.Length+1);
            Models.Restaurant restaurant =new Models.Restaurant(name);
        }


        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public Models.Restaurant GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(string name)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task04._28._23.Services.Interfaces.RestaurantInterface;

namespace Task04._28._23.Services.Implementations.Restaurant
{
    internal class RestaurantServices : IRestaurantServices
    {
        List<Models.Restaurant> restaurants = new List<Models.Restaurant>() ;
        public void Create(string name)
        {
            Models.Restaurant restaurant = new Models.Restaurant();

            restaurant.Name = name;

            restaurants.Add(restaurant);


        //    Array.Resize(ref restaurants, restaurants.Length+1);
        //    Models.Restaurant restaurant =new Models.Restaurant(name);
        }


        public void Delete(string name)
        {
            //int count = restaurants.RemoveAll(x => x.Name == name);
            foreach (var item in restaurants)
            {
                if (item.Name == name)
                {
                    restaurants.Remove(item);
                }
            }
        }

        public Models.Restaurant GetById(int id)
        {
            Models.Restaurant ans = restaurants.Find(x => x.Id == id);
            return ans;
            
            //foreach (var item in restaurants)
            //{
            //    if (item.Id == id)
            //    {
            //        return item;
            //    }
            //}return null;
        }

        //public void Update(Restaurant restaurant)
        //{
            
        //}
    }
}

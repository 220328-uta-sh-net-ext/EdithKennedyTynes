using RestaurantDL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL
{
    public class RestaurantLogic : IRestaurantLogic
    {
        IRepository repo = new Repository();
        public Restaurant AddRestaurant(Restaurant r)
        {
            Random rendom = new Random();
            var Restaurant = repo.GetAllRestaurants();
        }

        public void SearchRestaurant()
        {
            var rest = repo.GetAllRestaurants();
        }

        public List<Restaurant> SearchRestaurant(string name)
        {
            var Restaurants = repo.GetAllRestaurants();
        }

        public object SearchRestaurants(string? name)
        {
            throw new NotImplementedException();
        }
        public void AddReview(string StoreId RateToAdd)
        {

        }
    }
}

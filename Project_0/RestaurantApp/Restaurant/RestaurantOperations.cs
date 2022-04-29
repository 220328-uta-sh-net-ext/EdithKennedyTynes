using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
using RestaurantModel;

namespace RestaurantUI
{
    internal class RestaurantOperations
    {
        static Repository repository = new Repository();

        public static void GetAllRestaurants()
        {
            var restaurants = repository.GetAllRestaurants();
            foreach (var rest in restaurants)
            {
                Console.WriteLine(rest.ToString());
                Console.WriteLine("~~~~~~~~~~~~~~~~~~");
            }
        }
        public static void AddDummyRestaurant()
        {

            Restaurant restaurant1 = new Restaurant()
            {
                Name = "Captain Georges",
                Review = "The crab legs here are the bomb",
                City = "Norfolk",
                State = "Virginia",
                StoreIDs = new List<StoreID>()
                {
                    new StoreID()
                    {
                        Accommodations = "Family",
                        ManagerID = 7575757,
                        Rating = 4,
                        Standards = "Fine Dining",
                    }
                }

            };

            repository.AddRestaurant(restaurant1);
    


            
        }

    }

}

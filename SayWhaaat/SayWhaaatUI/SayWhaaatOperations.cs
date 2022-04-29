using SayWhaaatDL;
using SayWhaaatModel;
using System;
using System.Collections.Generic;

namespace SayWhaaatUI
{
    internal class SayWhaaatOperations
    {
        static Repository repository = new Repository();

        public static void GetAllSayWhaaat()
        {
            var restaurant = repository.GetAllRestaurants();
            foreach (var rest in restaurants)
            {
                Console.WriteLine(rest.ToString());
                Console.WriteLine("=======================");
            }
        }
        /// <summary>
        /// only for test purposes to check if restaurants were added
        /// </summary>
        public static void AddDummyRestaurant()
        {
            Restaurant restaurant1 = new Restaurant()
            {
                Name = "Panera",
                Address = "515 SayWhaaat Dr, Norfolk Va 23508",
                Rating = 3,
                Reviews= "Best in the city"
                ,
                Standards = new List<Standard>() {
                    new Standard()
                    {
                        Name = "Casual Dining",
                        GuestType = "Professional, ChildFriendly",
                        PopularityScore = 01,
                        Entertainment = "WIFI",
                        StndType = "CafeBistro"
                    }
                }
            };

            repository.AddRestaurant(restaurant1);
        }
    }
}


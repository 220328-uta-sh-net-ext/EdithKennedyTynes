using System.Collections.Generic;
using SayWhaaatModel;

namespace SayWhaaatDL
{
    public interface IRepository
    {
        /// <summary>
        /// Add a Restaurant to our database
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns>The restaurant added</returns>
        Restaurant AddRestaurant(Restaurant restaurant);
        /// <summary>
        /// Will return All the Restaurants in the database
        /// </summary>
        /// <returns>Returns a collection of Restaurants as Generic List</returns>
        List<Restaurant> GetAllRestaurants();

    }
}

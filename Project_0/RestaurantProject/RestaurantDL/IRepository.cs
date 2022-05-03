using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModel;


namespace RestaurantDL
{/// <summary>
/// Data layer project is responsible for interacting with our database and doing CRUD operations
/// (CRUD) C - Create, R - Read, U - Update, D - Delete
/// </summary>
    public interface IRepository
    {
        Restaurant AddRestaurant(Restaurant rest); //Method to add restaurant


        List<Restaurant> GetAllRestaurants(); // method to view all restaurants in database and return them as a generic list 


        Restaurant AddReview(Restaurant rest); // method to add review 
        void AddReview(int StoreIDs, Repository.Review reviewToAdd);
    }
    
}

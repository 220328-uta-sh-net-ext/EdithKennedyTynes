using ChopHouseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopHouseDL
{
    /// <summary>
    /// Data layer project is responsible for interacting with our database and doing CRUD operations
    /// (CRUD) C - Create, R - Read, U - Update, D - Delete
    /// </summary>
    public interface IRepository      
    {
        public ChopHouse AddRestaurant(ChopHouse Chop); //Method to add restaurant adding to sql repo


        List<ChopHouse> GetAllRestaurants(); // method to view all restaurants in database and return them as a generic list 


        //ChopHouse AddReview(ChopHouse rest); 
        void AddReview(string StoreIDs, int reviewToAdd);// method to add review 



    }  
    public interface IRepositoryUser
    {
        User AddUser(User use); //copy on top for add user (AddRestaurant)

        List<User> DisplayUsers();
    }

    

}


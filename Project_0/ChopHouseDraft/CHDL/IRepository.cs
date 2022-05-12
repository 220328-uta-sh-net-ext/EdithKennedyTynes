using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHModel;

namespace CHDL
{
    public interface IRepository
    {
        public ChopHouse AddRestaurant(ChopHouse rest); //Method to add restaurant CALLING ONE 


        List<ChopHouse> GetRestaurants(); // method to view a restaurants filtered in database and return them as a generic list... CALLING A COLLECTION 

        List<ChopHouse> DisplayAll(ChopHouse play); // display collection of all restaurants
        
        //ChopHouse AddReview(ChopHouse rest); 
        public HouseReview AddHouseReview(HouseReview view);// method to add review 
        List<ChopHouse> DisplayAll();
    }
    public interface IRepositoryUser
    {
        User CreateUser(User use); 

        List<User> DisplayUsers();
    }

}

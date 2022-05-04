using ChopHouseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopHouseBL
{ 
    public interface IRestaurantLogic
    {
        ChopHouse AddRestaurant(ChopHouse Chop);


        List<ChopHouse> SearchRestaurant(string name);
        List<ChopHouse> DisplayAll();

        void AddReview(string ID, int Rating); 


    }
    public interface IUserLogic
    {
        User CreateUser(User Create);
        List<User> SearchAll();
    }
       
    
}

using CHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHBL
{
    public interface IChopHouseLogic
    {
        ChopHouse AddRestaurant(ChopHouse rest);


        List<ChopHouse> GetRestaurants(string Name, string City);
        
        List<ChopHouse> DisplayAll(string r, string seeAll); // CALLED IN REPO


        void AddReview(string ID, int Rating);


    }
    interface IRestaurantSearch
    {
        List<ChopHouse> SearchAll();
    }
    public interface IUserLogic
    {
        User CreateUser(User Create);
        List<User> SearchAll();
    }

}

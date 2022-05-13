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
        public ChopHouse AddRestaurant(ChopHouse rest);


        public List<ChopHouse> SearchRestaurants(string name);
        //public List<ChopHouse> SearchRestaurants(string City);
        //public List<ChopHouse> SearchRestaurants(string name);

        public List<ChopHouse> DisplayAll(); // method returns all restaurants from database CALLED IN sqlREPO


        public HouseReview AddHouseReview(HouseReview view);


    }
    interface IRestaurantSearch
    {
        string Name { get; }    
        //public List<ChopHouse> SearchRestaurants(string name, string city);
    }
    
}

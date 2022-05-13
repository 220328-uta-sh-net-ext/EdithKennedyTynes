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


        public List<ChopHouse> SearchRestaurants(string name, string s);

        //List<ChopHouse> DisplayAll(string r, string seeAll); // CALLED IN sqlREPO


        public HouseReview AddHouseReview(HouseReview view);


    }
    interface IRestaurantSearch
    {
        string Name { get; }    
        //public List<ChopHouse> SearchRestaurants(string name, string city);
    }
    
}

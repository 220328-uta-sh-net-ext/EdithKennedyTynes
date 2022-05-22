using CHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHBL
{
    public interface IChopHouseLogic : IChopHouseSearch
    {
        public ChopHouse AddRestaurant(ChopHouse rest);
        /// <summary>
        /// this method adds a restaurant
        /// </summary>
        /// <param name="rest"></param>
        /// <returns>save restaurant passed into the parameter rest</returns>


        public List<ChopHouse> SearchRestaurants(string name);
        /// <summary>
        /// method allows you to do a filered search 
        /// </summary>
        /// <returns>filtered serach bu name </returns>
        //public List<ChopHouse> SearchRestaurants(string City);
        //public List<ChopHouse> SearchRestaurants(string name);

        public List<ChopHouse> GetAllChopHouses();
        /// <summary>
        /// method returns all restaurants from database CALLED IN sqlREPO
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>


        public HouseReview AddHouseReview(HouseReview view);


    }
    public interface IChopHouseSearch
    {
        /// <summary>
        /// This method returns a search of all Restaurants
        /// </summary>
        /// <returns>List of restaurants</returns>
        List<ChopHouse> SearchAll();
        Task<List<ChopHouse>> SearchAllAsync();

    }
}


using CHModel;
using CHDL;
using CHBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHBL
{
    
    public class ChopHouseLogic : IChopHouseLogic
    {
        readonly IRepository Repo;


        /// <summary>
        /// injecting dependency through Repo
        /// </summary>
        /// <param name="repo"></param>
        public ChopHouseLogic(IRepository repo)
        {
            this.Repo = repo;
        }
        /// <summary>
        /// method for adding a Restaurant to the ChopHouse Database
        /// </summary>
        /// <param name="rest"></param>
        /// <returns></returns>


        public ChopHouse AddRestaurant(ChopHouse rest)/// talks to the IRepo
        {
            ChopHouse _chopHouse = new ChopHouse();
            //return Repo.AddRestaurant(rest);
            if (rest == null)
                return (rest);
            //_chopHouse.Add(rest);
            return Repo.AddRestaurant(rest);
            /*...or?
                (rest == null)

                Console.WriteLine(rest);
            else
                Console.WriteLine("Null");*/

        }
        /// <summary>
        /// method for adding review as User
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public HouseReview AddHouseReview(HouseReview view)

        {
            HouseReview houseReview = new HouseReview();
            return Repo.AddHouseReview(view);
            //--database : name..  (id = StoreId)  <-find the restaurant
            //--set (review : Rating + review) (numRatings = numRatings + 1 )
            // numRatings / Rating 
            // float i = Rating / (numReviews*5)   i = 0.6
            //if(i <= 0.2) = 1; else if(0.4) = 2; else if(0.6) = 3; if(0.8) = 4; else 5
            //print ()
            //call to Anything(i);
            //if (i <= 0.2)
            //{ 
            //Repo.AddReview(ID, Rating);
            //Chop.Anything(Rating);
            //}

            //throw new NotImplementedException();
        }
        /// <summary>
        /// asynchronous method using await keyword
        /// </summary>
        /// <returns>results directly from the database out of order of the synchronous thread primarily used for large request of records</returns>

        public async Task<List<ChopHouse>> SearchAllAsync()//--async means the method is asynchronous it might have 1 or more awaits
        {
            return await Repo.GetAllChopHouseAsync();//await keyword ensures where we wait for intensive computation method and it will release main thread 
                                                        //Task.Run is used to create a new thread to run this method, but if this method is async as well then we need not to use Task.Run
                                                        //Action is a delegate of type void

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ChopHouse> GetAllChopHouses()//calling method of stored variables in repo of restaurants in chophouse
        {
            return Repo.GetAllChopHouses();
            /*var chophouse = Repo.DisplayAll(); 
            return chophouse;
            var filteredRestaurants = seeRest;
            throw new NotImplementedException();
            if (Console.ReadLine() is not string Name)
                throw new InvalidDataException("");
            return filteredRestaurants;*/
        }
        public List<ChopHouse> SearchAll()
        {
            return Repo.GetAllChopHouses();
        }


        public List<ChopHouse> SearchRestaurants(string name) // talks to repo 
        {
            List<ChopHouse>? restaurants = Repo.SearchRestaurants();

            var filteredRestaurants = restaurants.Where(r => r.Name.Contains(name)).ToList();
            return filteredRestaurants;
        }
    }
    
}
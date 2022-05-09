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

        public ChopHouseLogic()
        {
        }

        public ChopHouseLogic(IRepository repo, IChopHouseLogic houseLogic)//injecting dependency through Re
        {
            this.Repo = repo;
        }

        public ChopHouse AddRestaurant(ChopHouse rest)/// talks to the IRepo
        {
            return Repo.AddRestaurant(rest);
        }

        public void AddReview(string ID, int Rating)

        {
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

        public List<ChopHouse> DisplayAll(string r, string seeAll)
        {
            List<ChopHouse>? seeRest = Repo.GetRestaurants(r, seeAll);
            var filteredRestaurants = seeRest;
            throw new NotImplementedException();
            if (Console.ReadLine() is not string Name)
                throw new InvalidDataException("");
            return filteredRestaurants;
        }

        public List<ChopHouse> GetRestaurants(string name, string s) // talks to repo 
        {
           
            List<ChopHouse>? restaurants = Repo.GetRestaurants(name, s);
            var filteredRestaurants = restaurants;
            //string Name = Console.ReadLine();
            if (Console.ReadLine() is not string Name)
                throw new InvalidDataException("");

          
            if (s == "Name")// when ever s is read is it == to name and city? else print all restaurants
                filteredRestaurants = restaurants.Where(restaurant => restaurant.Name.Contains(Name)).ToList();
            else if (s == "City")
                filteredRestaurants = restaurants.Where(restaurant => restaurant.City.Contains(Name)).ToList();
            else
                filteredRestaurants = restaurants.Where(restaurant => restaurant.City.Contains("")).ToList();
            return filteredRestaurants;
            /*foreach (var rest in Restaurants)
            {
                if (rest.Name.Contains(name))
                {
                    filteredRestaurants.Add(rest);
                    return filteredRestaurants;
                }
            }*/
           
        }
    }
    public class CHUserLogic : IUserLogic
    {

        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }

        public List<User> SearchAll()
        {
            throw new NotImplementedException();
        }

    }
}
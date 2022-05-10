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
        

        /*public ChopHouseLogic()
        {
        }*/

        public ChopHouseLogic(IRepository repo)//injecting dependency through Repo
        {
            this.Repo = repo;
        }
     

        public ChopHouse AddRestaurant(ChopHouse rest)/// talks to the IRepo
        {
            //ChopHouse chopHouse = new ChopHouse();
            return Repo.AddRestaurant(rest);

            /*if (rest == null)
            
                Console.WriteLine(rest);
            else
                Console.WriteLine("Null");*/
            



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
            List<ChopHouse>? seeRest = Repo.GetRestaurants();
            var filteredRestaurants = seeRest;
            throw new NotImplementedException();
            if (Console.ReadLine() is not string Name)
                throw new InvalidDataException("");
            return filteredRestaurants;
        }

        public List<ChopHouse> GetRestaurants(string name, string city) // talks to repo 
        {
            List<ChopHouse>? restaurants = Repo.GetRestaurants();
            //var filteredRestaurants = Repo.GetRestaurants(name);
            var filterRestaurants = from r in restaurants where r.Name.Contains(name) select r;

            var filteredrestaurants = from r in restaurants where r.City.Contains(city) select r;

            /*List<ChopHouse> filteredRestaurants = new List<ChopHouse>();
            foreach (var house in restaurants)
            {
                if (house.Name.Contains(name))
                {
                    filterRestaurants.Add(house);
                }*/
            return restaurants;
        }

        /*string Name = Console.ReadLine();
            if (Console.ReadLine() is not string Name)
            throw new InvalidDataException("");
        if (s == "Name")// when ever s is read is it == to name and city? else print all restaurants
            filteredRestaurants = restaurants.Where(restaurant => restaurant.Name.Contains(Name)).ToList();
        else if (s == "City")
            filteredRestaurants = restaurants.Where(restaurant => restaurant.City.Contains(Name)).ToList();
        else
            filteredRestaurants = restaurants.Where(restaurant => restaurant.City.Contains("")).ToList();
        return filteredRestaurants;
        foreach (var rest in Restaurants)
        {
            if (rest.Name.Contains(name))
            {
                filteredRestaurants.Add(rest);

            }return filteredRestaurants;
        }*/
    }



    public class CHUserLogic : IUserLogic
    {

        readonly IRepositoryUser Repo;

        public CHUserLogic()//injecting dependency through Re
        {
            this.Repo = Repo;
        }

        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<User> SearchAll()
        {
            throw new NotImplementedException();
        }
    
    }
}
  
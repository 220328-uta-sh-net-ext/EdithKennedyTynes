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

        public async Task<List<ChopHouse>> SearchAllAsync()//--async means the method is asynchronous it might have 1 or more awaits
        {
            return await Repo.GetAllChopHouseAsync();//await keywaord ensures where we wait for intensive computation method and it will release main thread 
            //Task.Run is used to create a new thread to run this method, but if this method is async as well then we need not to use Task.Run
            //Action is a delegate of type void

        }
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

      



        /*var filteredRestaurants = restaurants;*/

        /*if (Console.ReadLine() is not string Name)
            throw new InvalidDataException("");
        if (s == "Name")// when ever s is read is it == to name and city? else print all restaurants
            filteredRestaurants = restaurants.Where(restaurant => restaurant.Name.Contains(Name)).ToList();
        else if (s == "City")
            filteredRestaurants = restaurants.Where(restaurant => restaurant.City.Contains(s)).ToList();
        else
            filteredRestaurants = restaurants.Where(restaurant => restaurant.Name.Contains("")).ToList();
        return filteredRestaurants;
                    /*foreach (var rest in Restaurants)
                    {
                        if (rest.Name.Contains(name))
                        {
                            filteredRestaurants.Add(rest);
                            return filteredRestaurants;
                        }



                        /*
                        List<ChopHouse> filteredRestaurants = new List<ChopHouse>();
                        foreach (var house in restaurants)
                        {
                            if (house.Name.Contains(name))
                            {
                                filterRestaurants.Add(house);
                            }
                            return restaurants;
                        }



                        string Name = Console.ReadLine();
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

                            }

                }



            public class UserLogic : IUserLogic
            {

                readonly IRepositoryUser Repo;

                public UserLogic()//injecting dependency through Re
                {
                    this.Repo = Repo;
                }



            }*/

    }
}
  
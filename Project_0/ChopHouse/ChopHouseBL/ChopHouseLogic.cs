using ChopHouseDL;
using ChopHouseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChopHouseBL
{
    public class ChopHouseLogic : IRestaurantLogic // do your business here not in the interface for user 
    {
        readonly IRepository Repo;

        public ChopHouseLogic()
        {
        }

        public ChopHouseLogic(IRepository repo)
        {
            Repo = repo;
        }
        public ChopHouse AddRestaurant(ChopHouse Chop)
        {
            return Repo.AddRestaurant(Chop);
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

        public List<ChopHouse> DisplayAll()
        {
            List<ChopHouse> rest = Repo.GetAllRestaurants();
            return rest;

        }

        public List<ChopHouse> SearchRestaurant(string name)
        {
            throw new NotImplementedException();
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

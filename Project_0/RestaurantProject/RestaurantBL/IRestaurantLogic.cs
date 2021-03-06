using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace RestaurantBL
{
    public interface IRestaurantLogic 
    {
        Restaurant AddRestaurant(Restaurant r);


        List<Restaurant> SearchRestaurant(string name);

    }
    interface IRestaurantSearch
    {
        List<Restaurant> SearchAll();
    }
    public void AddReview();
}

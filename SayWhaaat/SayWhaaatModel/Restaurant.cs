using System;
using System.Collections.Generic;

namespace SayWhaaatModel;

public class Restaurant
{
    public string Name { get; set; }

    public string Address { get; set; }

    public int Rating { get; set; }

    public string Reviews { get; set; }
    public List<Standard> Standards { get; set; }

    public Restaurant()
    {
        Name = "Restaurant Name";
        Address = "818 SayWhaaat Ave, Norfolk Va 23508";
        Rating = 5; //star rating 1-5
        Reviews = "The BEST in the city!!!";
        

    }

    public override string ToString()
    {
        return $"Name: {Name}\nAddress: {Address}\nRating: {Rating}\nReviews: {Reviews}";

    }

    public class Add : Restaurant
    {
        private Restaurant restaurant;

        public Add(Restaurant restaurant)
        {
            this.restaurant = restaurant;
        }
    }
}
























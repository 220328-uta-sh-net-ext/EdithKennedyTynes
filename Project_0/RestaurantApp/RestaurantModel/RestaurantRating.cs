using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    internal class RestaurantRating
    {
        private int _rating;

        public int Rating
        {
            get { return _rating; }

            set
            {
                if (value < 0)
                    _rating = value;
                else
                    throw new Exception("rate must be no more than 5 stars");
            }
        }
        public RestaurantRating()
        {
            Rating = 1;
        }
    }
}    

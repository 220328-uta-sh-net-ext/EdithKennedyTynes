using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    internal class RestaurantRating
    {
        private double _ratings;

        public double Rating
        {
            get { return _ratings; }

            set
            {
                if (value < 0)
                    _ratings = value;
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

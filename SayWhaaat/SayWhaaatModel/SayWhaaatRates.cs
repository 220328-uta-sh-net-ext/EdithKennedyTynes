using System;

namespace SayWhaaatModel
{
    public class SayWhaaatRates
    {
        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value > 0)
                    _rating = value;
                else
                    throw new Exception("rate must be no more than 5 stars");

            }
        }

        public SayWhaaatRates()
        {
            Rating = 1;
        }
    }
}

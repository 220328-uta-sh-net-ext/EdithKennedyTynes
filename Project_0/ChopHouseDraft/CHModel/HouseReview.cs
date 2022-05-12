using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHModel
{
    public class HouseReview
    {
        public string StoreID { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
       public string Feedback { get; set; }
        public HouseReview()
        {
            StoreID = "CH5555";
            UserId = "CHU45655";
            Rating = 0;
            Feedback = "Great Place";
            

        }
        public override string ToString()
        {
            return $"StoreID: {StoreID}\nUserId: {UserId}\nRating: {Rating}\nFeedback: {Feedback}";
            
        }

    }
   
}

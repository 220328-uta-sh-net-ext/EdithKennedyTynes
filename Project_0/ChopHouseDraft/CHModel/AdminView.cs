using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CHModel
{
    public class AdminView
    {
        public int StoreID { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; } 
        public int NumRatings { get; set; }

        public AdminView()
        {
            StoreID = 0;
            UserId = 0;
            Rating = 0;
            NumRatings = 0;

        }
        public override string ToString()
        {
            return $"StoreID: {StoreID}\nUserId: {UserId}\nRating: {Rating}\nReview: {NumRatings}\n: {NumRatings}";
        }
    }
}

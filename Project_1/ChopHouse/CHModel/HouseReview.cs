using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHModel
{
    public class HouseReview
    {
        public int ?StoreID { get; set; }
        public int ?UserId { get; set; }
        public decimal Rating { get; set; }
        public string Feedback { get; set; }
        public HouseReview()
        {
            StoreID = 5555;
            UserId = 45655;
            Rating = 0;
            Feedback = "Great Place";


        }
        

    }
}

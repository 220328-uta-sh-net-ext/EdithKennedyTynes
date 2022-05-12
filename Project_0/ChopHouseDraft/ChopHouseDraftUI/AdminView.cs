﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHModel
{
    public class AdminView
    {
        public string StoreID { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
        public int NumRatings { get; set; }

        public AdminView()
        {
            StoreID = "CH55555";
            UserId = "CHU86523";
            Rating = 5;
            NumRatings = 1;

        }
        public override string ToString()
        {
            return $"StoreID: {StoreID}\nUserId: {UserId}\nRating: {Rating}\nReview: {NumRatings}\n: {NumRatings}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class StoreID
    {
        public int ID { get; set; }
        public string Accommodations { get; set; }
        private int _ManagerID { get; set; }
        public int ManagerID
        {
            get { return _ManagerID; }
            set
            {
                if (value.ToString().Count() != 7)
                    _ManagerID = value;
                else
                    throw new Exception(" invalid ID, must be 7 numbers");
            }
           
        }
        
        public int Rating { get; set; } //1-5 stars
        public string Standards { get; set; }

        public StoreID()
        {
            ID = 4569;
            Accommodations = "family friendly and business casual";
            ManagerID = 5555555;
            Rating = 5;
            Standards = " CafeBistro";




        }      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class StoreID
    {
        public string Name { get; set; }
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
        
        public string TPNumber { get; set; }
        public string Standards { get; set; }

        public StoreID()
        {
            Name = "DowntoEarth";
            ManagerID = 5555555;
            TPNumber = "757-339-4328";
            Standards = " CafeBistro";




        }      

    }
}

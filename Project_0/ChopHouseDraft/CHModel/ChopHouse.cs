using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHModel
{
    public class ChopHouse
    {
        public string StoreID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        


        public ChopHouse()
        {
            StoreID = "CH5555";
            Name = "??";
            City = "Norfolk";
            State = "Va";
            

        }
        public string Anything(float i)
        {
            return $"StoreID: {StoreID}\nName: {Name}\nCity: {City}\nState: {State}";
        }
        public override string ToString()
        {
            return $"StoreID: {StoreID}\nName: {Name}\nCity: {City}\nState: {State}";
        }

    }
}

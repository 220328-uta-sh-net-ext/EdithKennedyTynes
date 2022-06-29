using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHModel
{
    public class ChopHouse
    {
        public int ?StoreID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }



        public ChopHouse()
        {
            StoreID = 00000;
            Name = "??";
            City = "Norfolk";
            State = "Va";
            Zip = 23508;


        }
        public string Anything(float i)
        {
            return $"Name: {Name}\nCity: {City}\nState: {State}\nZip: {Zip}";
        }
        public override string ToString()
        {
            return $"Name: {Name}\nCity: {City}\nState: {State}\nZip: {Zip}";
        }

    }
}

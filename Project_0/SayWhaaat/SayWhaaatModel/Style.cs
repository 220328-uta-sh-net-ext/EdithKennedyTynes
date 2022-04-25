using SayWhaaatModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayWhaaatModel
{
    public class Style


    {   //most/Least expensive
        public string Pricing { get; set; }

        //TV, WIFI, Alcoholic Beverages, Bar, lounge, Hookah, Smoking, games 
        public string Entertainment { get; set; }

        string[] EntertainmentArray = Array.Empty<string>();

        //style: eccentric, modern, contemporary, industrial, classic, traditional, rustic, dark/night life, natural/eco-friendly, Cozy, Underwater

        private List<string> _styles = new List<string>();
         
        public List<string> Styles
        {
            get { return _styles; }
            set
            {
                if (value.Count < 2)
                    _styles = value;
                else
                    throw new Exception("Types can't hold anymore than 2 Types");

            }
           
        }

        public List<Standard> Standards { get; set; }

        public Style()
        {
            Pricing = "//$$$$$";
            Entertainment = "WIFI";
            


        }
        
    }
}


using SayWhaaatModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayWhaaatModel
{
    public class Standard
    {

        public string Name { get; set; }//RestaurantName
        public string GuestType { get; set; } /* Capacity accomadations; Professional, Romantic Date (2), family, catering, small/large groups, children friendly, pet friendly*/

        public int PopularityScore { get; set; }//most popular ranges from 1 - 8; 1 being the most popularType 

        public string Entertainment { get; set; }

        public string StndType { get; set; }


        public Standard()
        {
            Name = "Buffet" + "QSR";
            GuestType = "Professional";
            PopularityScore = 01;
            Entertainment = "WIFI";
            StndType = "CafeBistro";
        }


    }
}





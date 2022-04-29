using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayWhaaatModel
{
    /*standard: QSR/FastFood, Casual Dining, Fast casual restaurant, contemporary casual restauarants, Fine dining
    cafe', pizzerias, pop up, ghost kitchens, Eat & Play */
    public class StndType : Standard
    {
        public string QSRff { get; set; }
        public string CasualDining { get; set; }
        public string FastCasual { get; set; }
        public string ContemporaryCasual { get; set; }
        public string FineDining { get; set; }
        public string CafeBistro { get; set; }
        public string Pizzeria { get; set; }
        public string Popup { get; set; }
        public string Ghost { get; set; }
        public string Eat_Play { get; set; }


    }
}
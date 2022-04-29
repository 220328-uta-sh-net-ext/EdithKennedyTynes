using SayWhaaatBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayWhaaatUI
{
    internal class SearchRestaurantMenu : IMenu
    {
        ISayWhaaatLogic repo = new SayWhaaatLogic();
        public void Display();
        {
            Console.WriteLine("Please select an option to filter the pokemon database");
            Console.WriteLine("Press <3> By Name");
            Console.WriteLine("Press <2> By Rating");
            Console.WriteLine("Press <1> By GuestType");
            Console.WriteLine("Press <0> Go Back");
        }
            
    }
        
}
   

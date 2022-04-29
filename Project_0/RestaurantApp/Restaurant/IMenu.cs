using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal interface IMenu
    {
        /// <summary>
        /// Display menu & user choice in the terminal
        /// </summary>
        void Display();


        /// <summary>
        /// record user input and change/reroute the meun based on choice
        /// </summary>
        /// <returns>Return the menu that will change the prompt screen</returns>
        string UserChoice();
    }
}

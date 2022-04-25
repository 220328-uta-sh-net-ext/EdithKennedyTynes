using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayWhaaatUI
{
    /* 
 Interface are one of the best ways to implemnet abstraction 
Every method is implicitly abstract so you dont have to define your method
Every Method in interface is by default public so dont use public as a keyword

 */
    public interface IMenu
    {
        /// <summary>
        /// Will Display the menu and the user choices in the terminal 
        /// </summary>
        void Display();

        /// <summary>
        /// Will record the user's choice and change/route your menu based on that route
        /// </summary>
        /// <returns>Return the menu that will change your screen</returns>
        string UserChoice();

    }



}


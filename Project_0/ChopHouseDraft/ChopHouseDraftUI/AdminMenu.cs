using CHBL;
using CHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopHouseDraftUI
{
    public class AdminMenu : IMenu
    {
        public string SearchStoreID { get; set; }
        public string SearchUserId { get; set; }
        public int SearchRating { get; set; }
       

        public AdminMenu()
        {
            SearchStoreID = "CH55555";
            SearchUserId = "CHU86523";
            SearchRating = 5;
           

        }
        /*
        public override string ToString()
        {
            return $"StoreID: {StoreID}\nUserId: {UserId}\nRating: {Rating}\nReview: {NumRatings}\n: {NumRatings}";
        }
        */
        void IMenu.Display()
        {
            Console.WriteLine("Press <0> return to MainMenu");
            Console.WriteLine("Press <1> To login");
            Console.WriteLine("Press <2> SearchStoreID");
            Console.WriteLine("Press <3> SearchUserId");
            Console.WriteLine("Press <4> SearchRating");
            


        }
        
        
        public string UserChoice()
        {
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "0":
                    return "ReturnMain";
                case "1":
                    return "Login";
                case "2":
                    return "SearchRestaurant";
                case "3":
                    return "SearchRestaurant";
                case "4":
                    return "SearchRestaurant";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <Enter> to continue");
                    return "MainMenu";

            }
        }

    }
}

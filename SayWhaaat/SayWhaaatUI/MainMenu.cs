using System;

namespace SayWhaaatUI
{
    /*MainMenu class implements IMenu interface but since it is a class it needs to give actual implementation 
     details to the respective methods */
    class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("WhaaatsUp, WhaaatsUp, WhaaatsUp, SayWhaaat!");
            Console.WriteLine("SayWhaaat Restaurant do you want to view?");
            Console.WriteLine("Press <3> See All SayWhaaat Restaurants");
            Console.WriteLine("Press <2> Search Restaurants");
            Console.WriteLine("Press <1> Add Restaurant to SayWhaaat!");
            Console.WriteLine("Press <0> SayWhaaat? You want to Exit? Come back and see us!");

        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddRestaurantToSayWhaaat";
                case "2":
                    return "SearchSayWhaaat";
                case "3":
                    return "GetAllRestaurants";
                default:
                    Console.WriteLine("Please input a valid Response");
                    Console.WriteLine("Please press <Enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";

            }


        }


    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHBL;
using CHModel;

namespace ChopHouseUI
{
    public class AddHouseReview : IMenu
    {
        public static HouseReview newReview = new HouseReview();

        readonly IChopHouseLogic logic;

        public AddHouseReview(IChopHouseLogic logic)
        {
            this.logic = logic;
        }
        public void Display()
        {
            Console.WriteLine("Enter HouseReview Information");
            Console.WriteLine("<0> Go Back to MainMenu");
            Console.WriteLine("<1> StoreID - " + newReview.StoreID);
            Console.WriteLine("<2> UserId - " + newReview.UserId);
            Console.WriteLine("<3> Rating - " + newReview.Rating);
            Console.WriteLine("<4> FeedBack - " + newReview.Feedback);
            Console.WriteLine("<5> Save Restaurant");
        }

        public string UserChoice()
        {
            {
                if (Console.ReadLine() is not string userInput)
                    throw new InvalidDataException("");

                switch (userInput)
                {
                    case "0":
                        Log.Information("Returning to Main Menu");
                        return "MainMenu";
                    case "1":

                        try
                        {
                            Log.Information("Adding a HouseReview - " + newReview.StoreID);
                            Console.Write("Please enter a Restaurant StoreID");
                            newReview.StoreID = Console.ReadLine();
                            Log.Information("HouseReview StorID added successfully");
                        }
                        catch (Exception ex)
                        {
                            Log.Warning("failed to add StoreID");
                            Console.WriteLine(ex.Message);
                        }
                        return "AddHouseReview";
                    case "2":
                        try
                        {
                            Log.Information("Adding a HouseReview - " + newReview.UserId);
                            Console.Write("Please enter a UserId");
                            newReview.UserId = Console.ReadLine();
                            Log.Information("HouseReview UserId added successfully");
                        }
                        catch (Exception ex)
                        {
                            Log.Warning("failed to add UserId");
                            Console.WriteLine(ex.Message);
                        }
                        return "AddHouseReview";
                    case "3":
                        try
                        {
                            Log.Information("Adding HouseReview - " + newReview.Rating);
                            Console.Write("What would you rate this Restaurant");
                            newReview.Rating = Convert.ToInt32(Console.ReadLine());
                            Log.Information("HouseReview Rating added successfully");
                        }
                        catch (Exception ex)
                        {
                            Log.Warning("failed to add HouseReview Rating");
                            Console.WriteLine(ex.Message);
                        }
                        return "AddHouseReview";
                    case "4":
                        try
                        {
                            Log.Information("Adding HouseReview - " + newReview.Feedback);
                            Console.Write("Please submit feedback");
                            newReview.Rating = Convert.ToInt32(Console.ReadLine());
                            Log.Information("HouseReview Feedback added successfully");
                        }
                        catch (Exception ex)
                        {
                            Log.Warning("failed to add HouseReview Feddback");
                            Console.WriteLine(ex.Message);
                        }
                        return "AddHouseReview";
                    case "5":
                        try
                        {
                            Log.Information("Saving to ChopHouse.......");
                            logic.AddHouseReview(newReview); //calling method AddHouseReview: to add new restaurant into the database (sqlRepository)
                            Console.Write("......Saving to HouseReview to Datatbase......");
                            Log.Information("Saved successfully");
                        }
                        catch (Exception ex)
                        {
                            Log.Warning("failed to save HouseReview");
                            Console.WriteLine(ex.Message);
                        }
                        return "AddHouseReview";
                    default:
                        return "MainMenu";
                }


            }

        }

    }
}

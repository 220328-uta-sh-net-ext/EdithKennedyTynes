using System.Collections.Generic;
using Xunit;
using CHModel;
using ChopHouseDraftUI;


namespace ChopHouse_Test
{
    public class UnitTestUI
    {
        [Fact]
        public void SearchRestaurantTest()
        {
            //Facts are tests which are always true. They test invariant conditions
            //arrange, act, assert
            ChopHouse Restaurants = new ChopHouse();
            {
                Restaurants.StoreID = "CH96325";
                Restaurants.Name = "Tropical Smoothie";
                Restaurants.City = "Norfolk";
                Restaurants.State = "VA";
           
                


                Assert.Equal("CH96325", Restaurants.StoreID);
                Assert.Equal("Tropical Smoothie", Restaurants.Name);
                Assert.Equal("Norfolk", Restaurants.City);
                Assert.Equal("VA", Restaurants.State);
                /*Assert.Equal("Great", Restaurants.Review);
                Assert.Equal(1, Restaurants.NumRatings);
                Assert.Equal("CH96325", Restaurants.StoreID);*/
            }
        }
        [Fact]
        public void UserTest()
        {
            ChopHouse GetRest = new ChopHouse();

            User userTest = new User();

            userTest.UserID = "095463";
            userTest.FirstName = "Zyier";
            userTest.LastName = "Kennedy";
            userTest.UserName = "GoodForIt";
            userTest.Email = "GoodForIt@gmail.com";
            userTest.Password = "Pass1234";

            Assert.Equal("095463", userTest.UserID);
            Assert.Equal("Zyier", userTest.FirstName);
            Assert.Equal("Kennedy", userTest.LastName);
            Assert.Equal("GoodForIt", userTest.UserName);
            Assert.Equal("GoodForIt@gmail.com", userTest.Email);
            Assert.Equal("Pass1234", userTest.Password);
        }

    }


}
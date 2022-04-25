using SayWhaaatDL;
using SayWhaaatModel;

namespace SayWhaaatUI
{
    internal class SayWhaaatOperations
    {
        static Repository repository= new Repository();

        public static void AllSayWhaaatRestaurants() {
            repository.AllSayWhaaats();
        }
        public static void AddDummyRestaurant()
        {
            Restaurant restaurant1 = new Restaurant()
            {
                Name = "Panera",
                Theme = "Casual dining",
                Address = "500 SayWhaaat Ave, Norfolk Va 23508",
                Rating = 4, //star rating 1-5
                Reviews = "I love this location!!!",
                Styles = new List<Style>()
                {
                    new Style()
                    {
                        Pricing = "//$$",
                        Entertainment = "WIFI",
                        Standards = new List<Standard>(){
                            new Standard()
                            {
                                Name = "Fast Casual Dining",
                                CapacityAccomodations = "Family, Catering, Children Friendly, Professional",
                                PopularityScore = 2
                            }



                        }

                    }
                }

            };

            repository.AddRestaurant(restaurant1);
        }
    }
}

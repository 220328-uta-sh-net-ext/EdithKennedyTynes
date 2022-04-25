namespace SayWhaaatModel
{
    public class Standard

    {
            //RestaurantName
            public string Name { get; set; }

            /* Capacity accomadations; Professional, Romantic Date (2), family, catering, small/large groups,
             children friendly, pet friendly*/
            public string CapacityAccomodations;

            string[] CapacityArray = Array.Empty<string>();



            /*types: QSR/FastFood, Casual Dining, Fast casual restaurant, contemporary casual restauarants,
            buffet, cafe/bistro, pizzerias, pop up, ghost kitchens */
            public string Type { get; set; }
            string[] TypeArray = Array.Empty<string>();

            //most popular ranges from 1 - 8; 1 being the most popularType 

            public int PopularityScore { get; set; }
           

            public Standard()
            {
                Name = "Buffet" + "QSR";
                CapacityAccomodations = "Capacity Accomodations";
                PopularityScore = 01;

            }

        
    }
}





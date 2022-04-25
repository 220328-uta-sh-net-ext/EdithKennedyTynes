 using SayWhaaatModel;


namespace SayWhaaatModel
{
    public class Restaurant
    {
        public string Name { get; set; }

        /*Themes: food & menu, (casual dining; american/traditional, diner foods, soul foods, comfort foods, Seafood,
         * Ethnic: Italian, Mexican, African, Indian Middle Eastern, Chinese, Japanese*/

        public string Theme { get; set; }

        public string Address { get; set; }

        public int Rating { get; set; }

        public string Reviews { get; set; }

        /*types: QSR/FastFood, Casual Dining, Fast casual restaurant, contemporary casual restauarants, Fine dining
        cafe', pizzerias, pop up, ghost kitchens, Eat & Play */

        private List<Standard> _standards;

        public List<Standard> Standards
        {
            get { return _standards; }
            set
            {
                if (value.Count <= 1)
                    _standards = value;
                else  
                    throw new Exception("Restaurants cannot hold more than one Standard");
            }

        }
        public List<Style> Styles;
        public Restaurant(List<Style> styles)
        {
            Styles = styles;
        }
        
        //Default Constructor to add default values to the properties

        public Restaurant()
        {
            Name = "Restaurant Name";
            Theme = "American";
            Address = "818 SayWhaaat Ave, Norfolk Va 23508";
            Rating = 5; //star rating 1-5
            Reviews = "The BEST in the city!!!";
            Standards = new List<Standard>();

            Standard standard1 = new Standard();
            Standard standard = standard1;

        }

        public override string ToString()
        {
            return $"Name: {Name}\nLevel: {Theme}\nAddress: {Address}\nRating: {Rating}\nReviews: {Reviews}";

        }
    }
}
























namespace ChopHouseModel
{
    public class ChopHouse
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public int NumRatings { get; set; }
        public string StoreID { get; set; }

        
        public ChopHouse()
        {
            Name = "??";
            City = "Norfolk";
            State = "Va";
            Rating = 5;
            Review = "Tell me about the food";
            NumRatings = 1;
            StoreID = "55555";
       
        }
        public  string Anything(float i)
        {
            return $"Name: {Name}\nCity: {City}\nState: {State}\nRating: {i}\nReview: {Review}";
        }
        public override string ToString()
        {
            return $"Name: {Name}\nCity: {City}\nState: {State}\nRating: {Rating}\nReview: {Review}";
        }
    }
}
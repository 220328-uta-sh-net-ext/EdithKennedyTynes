namespace RestaurantModel
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }

        private List<StoreID> _storeIDs;
        public List<StoreID> StoreIDs
        {
            get => _storeIDs ?? (_storeIDs = new List<StoreID>());
            set { if (value.Count <= 1)
                    _storeIDs = value;
                else
                    throw new Exception("Restaurant cannot hold more than 1 ID");
            }
        }
        public Restaurant()
        {
            Name = "??";
            City = "Norfolk";
            State = "Va";
            Rating = "5";
            Review = "Tell me about the food";
            _storeIDs = new List<StoreID>()
            {
                new StoreID()
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}\nCity: {City}\nState: {State}\nRating: {Rating}\nReview: {Review}";
        }

       

    } 
}
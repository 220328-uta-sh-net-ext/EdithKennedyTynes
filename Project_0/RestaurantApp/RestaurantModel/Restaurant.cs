namespace RestaurantModel
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string State { get; set; }

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
            Description = "Tell me about the food";
            City = "Norfolk";
            State = "Va";
            _storeIDs = new List<StoreID>()
            {
                new StoreID()
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nCity: {City}\nState: {State}";
        }



    } 
}
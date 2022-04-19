namespace RestaurantDL
{
    public abstract class RestaurantData
    {

        public abstract void add();

        private string? restaurantName;
        private string restaurant;

        public string GetRestaurantName()
        {
            return restaurant;
        }

        public void SetRestaurantName(string value)
        {
            restaurantName = value;
        }

        public string RestaurantStoreId { get; set;}

        


        //Find restaurant 
        //Restaurant Review
        //Modify Restaurant 
        //Calulate Average
        //saved Restaurant averages

    }
}
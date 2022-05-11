namespace ChopHouseAPI
{
    public class WeatherForecast
    {
        // controller is like the security guard the front desk give access to rest of infrastructure to handle users request 
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
namespace Road_Safety_Project.Models
{
    public class WHT_Weather
    {
        public int WeatherID { get; set; }
        public DateTime WeatherDate { get; set; }
        public string? WeatherTemperatuer { get; set; }
        public int WeatherWindSpeed { get; set; }
        public string? WeatherWindDirection { get; set; }
        public int WeatherHumidity { get; set; }
        public string? WeatherPreciption { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}

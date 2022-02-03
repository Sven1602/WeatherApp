namespace WetterApp.Models
{
    public class WeatherViewModel
    {
        public string City { get; set; }
        public float Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }
        public float WindSpeed { get; set; }
        public int WindDeg { get; set; }
        public string Country { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }


    }
}

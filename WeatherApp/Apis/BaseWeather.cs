using WetterApp.Models;

namespace WeatherApp.Apis
{
    public abstract class BaseWeather
    {
        public abstract WeatherDataResponse getData(string city, string lang);
    }
}

using WetterApp.Models;

namespace WeatherApp.Interface
{
    public interface IDatabase
    {
        WeatherDataResponse getWeatherDatas(string city, string lang);
    }
}

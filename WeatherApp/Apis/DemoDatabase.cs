using WeatherApp.Interface;
using WetterApp.Models;

namespace WeatherApp.Apis
{
    public class DemoDatabase : IDatabase
    {
        /// <summary>
        /// Zugriff auf die Datenbank und abrufen der Datensätze
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public WeatherDataResponse getWeatherDatas(string city, string lang)
        {
            throw new NotImplementedException();
        }
    }
}

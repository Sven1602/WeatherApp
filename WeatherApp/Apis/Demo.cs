using WeatherApp.Interface;
using WetterApp.Apis;
using WetterApp.Interface;
using WetterApp.Models;

namespace WeatherApp.Apis
{
    public class Demo : BaseWeather
    {
        // andere Json Api
        private IApi api = new DemoApi();
        
        private IDatabase database = new DemoDatabase();

        public override WeatherDataResponse getData(string city, string lang)
        {
     
            //WeatherDataResponse weatherData = database.getWeatherDatas(city, lang);

            //Test Object
            WeatherDataResponse weatherData = new WeatherDataResponse();
            weatherData.Name = "Erfurt";
            weatherData.Main = new Main();
            weatherData.Main.Temp = 12.5f;
            weatherData.Main.Pressure = 120;
            weatherData.Main.Humidity = 12;
            weatherData.Main.Temp_Max = 13.0f;
            weatherData.Main.Temp_Min = 1.0f;
            weatherData.Wind = new Wind();
            weatherData.Wind.Deg = 12;
            weatherData.Wind.Speed = 20.0f;
            weatherData.Sys = new Sys();
            weatherData.Sys.Country = "DE";

            // weitere Eigenschaften setzen
            return weatherData;
        }
    }
}

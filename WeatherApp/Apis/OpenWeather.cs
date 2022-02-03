using Newtonsoft.Json;
using WetterApp.Apis;
using WetterApp.Interface;
using WetterApp.Models;

namespace WeatherApp.Apis
{
    public class OpenWeather : BaseWeather
    {
        private IApi api = new OpenWeatherApi();

        public override WeatherDataResponse getData(string city, string lang)
        {
            string jsonResponse = api.GetWeatherDatas(city, lang);

            WeatherDataResponse result = JsonConvert.DeserializeObject<WeatherDataResponse>(jsonResponse);

            return result;
        }
    }
}

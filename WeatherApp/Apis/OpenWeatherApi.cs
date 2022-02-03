using WetterApp.Interface;
using System.Net;

namespace WetterApp.Apis
{
    public class OpenWeatherApi : IApi
    {
        public string GetWeatherDatas(string city, string lang)
        {
            string appId = Configs.Keys.WEATHERAPIKEY;
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&APPID={1}&lang={2}", city, appId, lang);

            try
            {
                using (WebClient client = new WebClient())
                {
                    string jsonResponse = client.DownloadString(url);

                    if (jsonResponse != null)
                    {
                        return jsonResponse;
                    }
                    else
                    {
                        Console.WriteLine("jsonRespone ist null.");
                        return string.Empty;
                    }
                }
            }
            catch (WebException exception)
            {
                throw exception;
            }

        }
    }
}

using WetterApp.Interface;

namespace WetterApp.Apis
{
    /// <summary>
    /// DemoApi - eigene Api oder Alternativ Api um die Wetterdaten zu ermitteln.
    /// </summary>
    public class DemoApi : IApi
    {   
        public string GetWeatherDatas(string city, string lang)
        {
            throw new NotImplementedException();
        }
    }
}

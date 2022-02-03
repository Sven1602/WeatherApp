using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using WeatherApp.Apis;
using WeatherApp.Models;
using WetterApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// gewünschte Wetter - Api einbinden 
        /// </summary>
        //private BaseWeather baseWeather = new Demo();
        private BaseWeather baseWeather = new OpenWeather();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public JsonResult WeatherData(string city, string lang)
        {
            try
            {
                var result = baseWeather.getData(city, lang);

                WeatherViewModel weatherViewModel = new WeatherViewModel();
                if (result != null)
                {
                    weatherViewModel.City = result.Name;
                    weatherViewModel.Temp = result.Main.Temp;
                    weatherViewModel.Pressure = result.Main.Pressure;
                    weatherViewModel.Humidity = result.Main.Humidity;
                    weatherViewModel.MaxTemp = result.Main.Temp_Max;
                    weatherViewModel.MinTemp = result.Main.Temp_Min;
                    weatherViewModel.WindDeg = result.Wind.Deg;
                    weatherViewModel.WindSpeed = result.Wind.Speed;
                    weatherViewModel.Country = result.Sys.Country;
                    weatherViewModel.Icon = result.Weather[0].Icon;
                    weatherViewModel.Description = result.Weather[0].Description;
                }

                var json = new JsonSerializerOptions();
                return Json(weatherViewModel, json);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}
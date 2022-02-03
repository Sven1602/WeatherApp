namespace WetterApp.Models
{
    public class WeatherDataResponse
    {
        public List<Weather> Weather { get; set; }
      
        public Main Main { get; set; }
      
        public Wind Wind { get; set; }
      
        public Sys Sys { get; set; }
        
        public int Id { get; set; }

        public string Name { get; set; }
       
    }
}

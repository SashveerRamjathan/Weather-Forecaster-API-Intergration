using Newtonsoft.Json;

namespace APIWeatherApp.Models
{
    public class WeatherData
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public CurrentWeather CurrentWeather { get; set; }
    }
}

using Newtonsoft.Json;

namespace APIWeatherApp.Models
{
    public class ForecastWeatherData
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("forecast")]
        public Forecast Forecast { get; set; }
    }
}

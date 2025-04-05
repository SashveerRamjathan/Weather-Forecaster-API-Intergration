using Newtonsoft.Json;

namespace APIWeatherApp.Models
{
    public class WeatherCondition
    {
        [JsonProperty("text")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}

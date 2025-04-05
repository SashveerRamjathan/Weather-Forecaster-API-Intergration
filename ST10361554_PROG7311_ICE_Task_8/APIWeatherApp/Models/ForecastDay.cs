using Newtonsoft.Json;

namespace APIWeatherApp.Models
{
    public class ForecastDay
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }
    }
}

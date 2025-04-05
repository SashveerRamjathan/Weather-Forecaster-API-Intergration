using Newtonsoft.Json;

namespace APIWeatherApp.Models
{
    public class Forecast
    {
        [JsonProperty("forecastday")]
        public List<ForecastDay> ForecastDays { get; set; }
    }
}

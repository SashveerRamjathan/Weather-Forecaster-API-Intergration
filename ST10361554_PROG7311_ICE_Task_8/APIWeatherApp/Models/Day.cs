using Newtonsoft.Json;

namespace APIWeatherApp.Models
{
    public class Day
    {
        [JsonProperty("maxtemp_c")]
        public double MaxTempC { get; set; }

        [JsonProperty("mintemp_c")]
        public double MinTempC { get; set; }

        [JsonProperty("avgtemp_c")]
        public double AvgTempC { get; set; }

        [JsonProperty("maxwind_kph")]
        public double MaxWindKph { get; set; }

        [JsonProperty("totalprecip_mm")]
        public double TotalPrecipitationMm { get; set; }

        [JsonProperty("avgvis_km")]
        public double AvgVisibilityKm { get; set; }

        [JsonProperty("uv")]
        public double UVIndex { get; set; }

        [JsonProperty("daily_chance_of_rain")]
        public double ChanceOfRain { get; set; }

        [JsonProperty("condition")]
        public WeatherCondition Condition { get; set; }
    }
}

using Newtonsoft.Json;

namespace APIWeatherApp.Models
{
    public class CurrentWeather
    {
        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("temp_c")]
        public double TemperatureC { get; set; }

        [JsonProperty("condition")]
        public WeatherCondition Condition { get; set; }

        [JsonProperty("wind_kph")]
        public double WindSpeedKph { get; set; }

        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDirection { get; set; }

        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonProperty("precip_mm")]
        public double PrecipitationMm { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloud")]
        public int CloudCover { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelsLikeC { get; set; }

        [JsonProperty("windchill_c")]
        public double WindChillC { get; set; }

        [JsonProperty("heatindex_c")]
        public double HeatIndexC { get; set; }

        [JsonProperty("dewpoint_c")]
        public double DewPointC { get; set; }

        [JsonProperty("vis_km")]
        public double VisibilityKm { get; set; }

        [JsonProperty("uv")]
        public double UVIndex { get; set; }

        [JsonProperty("gust_kph")]
        public double GustSpeedKph { get; set; }
    }
}

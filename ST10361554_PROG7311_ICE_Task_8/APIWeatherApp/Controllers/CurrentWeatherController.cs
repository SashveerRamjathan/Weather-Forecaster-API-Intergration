using APIWeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIWeatherApp.Controllers
{
    public class CurrentWeatherController : Controller
    {
        private readonly ILogger<CurrentWeatherController> _logger;
        private readonly HttpClient _httpClient;
        private const string _APIKEY = "5083d396286040bead3100630252803";
        private const string _APIURL = "https://api.weatherapi.com/v1/current.json";
        private const string _DEAFULT_LOCATION = "Durban";

        public CurrentWeatherController(ILogger<CurrentWeatherController> logger, HttpClient client)
        {
            _logger = logger;
            _httpClient = client;
        }

        public async Task<IActionResult> Index(string? location)
        {
            try
            {
                if (!string.IsNullOrEmpty(location))
                {
                    _logger.LogInformation($"Getting weather data for {location}");

                    var weatherData = await GetCurrentWeatherDataAsync(location);

                    if (weatherData != null)
                    {
                        return View(weatherData);
                    }

                    return RedirectToAction(nameof(Error));
                }

                _logger.LogInformation("No location provided. Getting default weather data");

                var defaultWeatherData = await GetCurrentWeatherDataAsync(_DEAFULT_LOCATION);

                if (defaultWeatherData != null)
                {
                    return View(defaultWeatherData);
                }

                return RedirectToAction(nameof(Error));
            }
            catch (Exception ex)
            {
                // log the error
                _logger.LogError(ex.Message, "Failed to get weather data");
                return RedirectToAction(nameof(Error));
            }
        }

        public IActionResult Error()
        {
            return View();
        }

        private async Task<WeatherData> GetCurrentWeatherDataAsync(string location)
        {
            // Build the URL
            string url = $"{_APIURL}?q={location}&key={_APIKEY}";

            _logger.LogInformation($"Getting weather data for {location}");

            try
            {
                // Make the request
                var response = await _httpClient.GetAsync(url);
                _logger.LogInformation($"Response sent to {url}");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    _logger.LogInformation("Request was successful");

                    // Read the response content
                    var content = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response
                    var weatherData = JsonConvert.DeserializeObject<WeatherData>(content);

                    _logger.LogInformation("Weather data deserialized");

                    // check if the data is null
                    if (weatherData == null)
                    {
                        // Log the error
                        _logger.LogError("Failed to deserialize weather data");
                        return null!;
                    }

                    return weatherData;
                }
                else
                {
                    // Log the error
                    _logger.LogError($"Failed to get weather data. Status code: {response.StatusCode}");
                    return null!;
                }
            }
            catch (Exception ex)
            {
                // log the exception
                _logger.LogError(ex.Message, "Failed to get weather data");
                return null!;
            }

        }
    }
}

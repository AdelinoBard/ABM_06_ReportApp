public class MockWeatherForecastService : IWeatherForecastService
{
    public IEnumerable<WeatherForecast> GetForecasts()
    {
        return new List<WeatherForecast>
        {
            new WeatherForecast { Date = DateTime.Now, TemperatureC = 25, Summary = "Ensolarado" },
            new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 22, Summary = "Nublado" },
            new WeatherForecast { Date = DateTime.Now.AddDays(2), TemperatureC = 18, Summary = "Chuvoso" }
        };
    }
}

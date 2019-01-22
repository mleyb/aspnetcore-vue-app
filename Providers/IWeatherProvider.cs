using System.Collections.Generic;
using AspNetCoreVueApp.Models;

namespace AspNetCoreVueApp.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}

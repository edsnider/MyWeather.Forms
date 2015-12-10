using System;
using System.Threading.Tasks;
using MyWeather.Models;
using MyWeather.Services;

namespace MyWeather
{
	public enum Units
	{
		Imperial,
		Metric
	}

	public interface IWeatherService
	{
		Task<WeatherRoot> GetWeather(double latitude, double longitude, Units units = Units.Imperial);
		Task<WeatherRoot> GetWeather(string city, Units units = Units.Imperial);
		Task<WeatherForecastRoot> GetForecast(int id, Units units = Units.Imperial);
	}
}


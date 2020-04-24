using System;

namespace WeatherBroadCast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var weatherData = new WeatherData() {Temperature = "32C", Humidity = "34%", Wind ="70km/hW", Forecast = "Rain" };
            var weatherStation = new WeatherStation();
            var weatherUpdateReceiver = new WeatherUpdateReceiver();
            weatherStation.UpdatedWeatherData += weatherUpdateReceiver.OnUpdatedData;
            weatherStation.WeatherInfo(weatherData);
        }
    }
}

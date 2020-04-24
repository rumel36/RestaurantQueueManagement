using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBroadCast
{
    public class WeatherUpdateReceiver
    {
        public void OnUpdatedData(object source, WeatherReceiverEventArgs e) {

            Console.WriteLine("Today's weather: Temp: {0}, Humidity: {1} Wind: {2} Forecast: {3}", e.WeatherData.Temperature, e.WeatherData.Humidity, e.WeatherData.Wind, e.WeatherData.Forecast);
        }
    }
}

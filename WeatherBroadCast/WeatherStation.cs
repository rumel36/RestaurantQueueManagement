using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBroadCast
{
    public class WeatherReceiverEventArgs : EventArgs {

        public WeatherData WeatherData { get; set; }
    }
    public class WeatherStation
    {

        //public delegate void ReceiverEventHandler(object source, WeatherReceiverEventArgs args);
        public event EventHandler<WeatherReceiverEventArgs> UpdatedWeatherData;
        public void WeatherInfo(WeatherData data) {

            Console.WriteLine("Weather info braodcasting");
            OnUpdatedWeatherData(data);
        }

        protected virtual void OnUpdatedWeatherData(WeatherData data) {

            if (UpdatedWeatherData != null)
                UpdatedWeatherData(this, new WeatherReceiverEventArgs(){ WeatherData = data });

        }
    }
}

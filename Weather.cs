using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        public string condition;
        public int temperature;
        private List<string> weatherConditions = new List<string>() {"Cloudy", "Rainy", "Overcast", "Hot", "Clear Skies", "Hazy" };
        private List<int> weatherTemperature = new List<int>() {61, 92, 82, 55, 46, 102, 34, 49 };
        public Random rnd = new Random();
        public Weather()
        {
            ChooseWeather();
            ChooseTemperature();
        }
        public void ChooseWeather()
        {
            int n = rnd.Next(0, 5);
            condition = weatherConditions[n];            
        }

        public void ChooseTemperature()
        {
            int n = rnd.Next(0, 7);
            temperature = weatherTemperature[n];

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string condition;
        int temperature;
        List<string> weatherConditions;
        string predictedForecast;

        Random rnd = new Random();
        int number;

        public Weather()
        {
            weatherConditions = new List<string>();
            weatherConditions.Add("Hot. Sunny. Clear Sky.");
            weatherConditions.Add("Warm. Sunny. Cloudy.");
            weatherConditions.Add("Cold. No sun. Cloudy.");
            GetTemperature();
        }

        //determine teperature
        public void GetTemperature()
        {
            number = rnd.Next(1, 11);
            switch (number)
            {
                case 1:
                case 2:
                    temperature = 50;
                    predictedForecast = weatherConditions[2];
                    condition = "bad";
                    break;
                case 3:
                case 4:
                case 5:
                    temperature = 70;
                    predictedForecast = weatherConditions[1];
                    condition = "good";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    temperature = 80;
                    predictedForecast = weatherConditions[0];
                    condition = "perfect";
                    break;
                default:
                    break;
            }
        }

        public void DisplayTemperature()
        {
            Console.WriteLine($"\nToday's forecast: {predictedForecast} Temperature:{temperature}F");
        }
    }
}

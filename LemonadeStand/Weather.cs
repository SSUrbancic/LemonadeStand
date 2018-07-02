using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //MEMBER(HAS A)

        public string forecastedWeather;
        public string actualWeather;
        public int predictedTemperature;
        public int actualTemperature;
        public int weatherInfluence = 0;
        public Random random = new Random();

        List<string> weather = new List<string>() { "Rainy", "Clear and Sunny", "Cloudy" };

        //CONTRTUCTOR
        public Weather()
        {
            DetermineForcast();
            DeterminePredictedTemperature();
            DetermineActualTemperature();
            DetermineActualWeather();
            DetermineWeatherInfluence();
        }
        //METHODS (CAN DO)
        private static readonly Random randomInt = new Random();
        private static readonly object syncLock = new object();

        public int RandomNumberGenerator(int min, int max)
        {
            lock (syncLock)
            {
                int RandomNumber = randomInt.Next(min, max);
                return RandomNumber;
            }
        }

        public void DetermineForcast()
        {
            forecastedWeather = weather[RandomNumberGenerator(0, weather.Count - 1)];
        }
        public void DetermineActualWeather()
        {
            if (RandomNumberGenerator(0, 100) <= 50)
            {
                actualWeather = weather[RandomNumberGenerator(0, weather.Count - 1)];
            }
            else
            {
                actualWeather = forecastedWeather;
            }
        }
        public void DeterminePredictedTemperature()
        {
            predictedTemperature = RandomNumberGenerator(60, 101);
        }
        public void DetermineActualTemperature()
        {
            actualTemperature = predictedTemperature + RandomNumberGenerator(-10, 11);
        }
        public void DetermineWeatherInfluence()
        {
            if (actualWeather == "Rainy")
            {
                weatherInfluence -= 10;
            }
            if (actualWeather == "Clear and Sunny")
            {
                weatherInfluence += 10;
            }
            if (actualWeather == "Cloudy")
            {
                weatherInfluence -= 5;
            }
            if (actualTemperature > 99)
            {
                weatherInfluence += 15;
            }
            if (actualTemperature >= 70 && actualTemperature <= 99)
            {
                weatherInfluence += 10;
            }
            if (actualTemperature < 70)
            {
                weatherInfluence += RandomNumberGenerator(-6, 7);
            }
        }
    }
}

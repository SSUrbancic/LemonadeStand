using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //Member(HAS A)
        public bool willBuyLemonade;
        Weather weather;
        Player playerOne;

        //Constructor
        public Customer(Weather weather, Player playerOne)
        {
            this.weather = weather;
            this.playerOne = playerOne;
            DetermineIfCustomerWillBuyLemonade();
        }
        //Methods(CAN DO)
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
        public void DetermineIfCustomerWillBuyLemonade()
        {
            if (playerOne.lemonadeRecipe.pricePerCup < .50 || (weather.actualTemperature > 80 && playerOne.lemonadeRecipe.pricePerCup < .75))
            {
                if (RandomNumberGenerator(0,100) + weather.weatherInfluence > 73)
                {
                        willBuyLemonade = true;
                }
            }
        }
    }
}

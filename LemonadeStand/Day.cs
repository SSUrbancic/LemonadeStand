﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //MEMBERS(HAS A)
        public int customerCountPerDay;
        public int cupCount = 0;
        Player playerOne;
        Weather weather;
        Customer customer;



        //CONSTRUCTOR
        public Day(Player playerOne, Weather weather, Customer customer)
        {
            this.playerOne = playerOne;
            this.weather = weather;
            this.customer = customer;
        }
        //METHODS
        public void ExecuteDailyLemonadeSales()
        {
            GenerateCustomersPerDay();
            while (customerCountPerDay > 0 && playerOne.iceCubeCount - playerOne.lemonadeRecipe.iceCubesPerCup > 0 && playerOne.lemonCount - playerOne.lemonadeRecipe.lemonsPerPitcher > 0 && playerOne.sugarCount - playerOne.lemonadeRecipe.sugarPerPitcher > 0)
            {
                customer = new Customer(weather, playerOne);
                CustomerPurchases();
                customerCountPerDay -= 1;
            }
        }
        public void GenerateCustomersPerDay()
        {
            int baseNumberOfCustomersPerDay = 99;
            customerCountPerDay = baseNumberOfCustomersPerDay + weather.weatherInfluence;
        }
        public void MakePitcherOfLemonade()
        {
            if (playerOne.lemonadeRecipe.lemonsPerPitcher > playerOne.lemonCount || playerOne.lemonadeRecipe.sugarPerPitcher > playerOne.sugarCount)
            {
                cupCount = 0;
            }
            else
            {
                playerOne.lemonCount -= playerOne.lemonadeRecipe.lemonsPerPitcher;
                playerOne.sugarCount -= playerOne.lemonadeRecipe.sugarPerPitcher;
                cupCount = 11;
            }
        }
        public void CustomerPurchases()
        {
            if (cupCount == 0)
            {
                MakePitcherOfLemonade();
            }
            
            if (customer.willBuyLemonade == true && playerOne.cupCount > 0)
            {

                    playerOne.cupCount -= 1;
                    playerOne.iceCubeCount -= playerOne.lemonadeRecipe.iceCubesPerCup;
                    playerOne.playerMoney += playerOne.lemonadeRecipe.pricePerCup;
                    cupCount -= 1;
                
            }            
        }
    }
}

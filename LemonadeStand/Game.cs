﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //members(HAS A)


        //Constructor
        public Game()
        {
            DetermineNumberOfPlayDays();
            IceCubes iceCubes = new IceCubes();
            Lemons lemons = new Lemons();
            Sugar sugar = new Sugar();
            Cups cups = new Cups();
            Player playerOne = new Player();
            Store itemStore = new Store(iceCubes, lemons, cups, sugar, playerOne);
            UserInterface userInterface = new UserInterface(playerOne);
            //DisplayInstructions();
          
           // DisplayMenuItems();
           // OfferPurchases();
            //SetLemonadeRecipe();
           // DisplayLemonadeRecipe();
        }
        //Methods(CAN DO)

       // public void DisplayInstructions()
       // {
       //     Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand. Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.Start with the basic recipe, but try to vary the recipe and see if you can do better.Lastly, set your price and sell your lemonade at the stand. Try changing up the price based on the weather conditions as well.At the end of the game, you'll see how much money you made. Write it down and play again to try and beat your score!");
      //  }

        public void DetermineNumberOfPlayDays()
        {
            Console.WriteLine("How many days do you want to play for? Enter 7, 14, or 21");
            int numberOfDays = int.Parse(Console.ReadLine());

            if(numberOfDays == 7)
            {
                Console.WriteLine("You have 7 days to sell as much lemonade as you can!");
                //send response to timer and make 7 day limit parameters
            }
            else if (numberOfDays == 14)
            {
                Console.WriteLine("You have 14 days to sell as much lemonade as you can!");
                //send response to timer and make 14 day limit parameters
            }
            else if (numberOfDays == 21)
            {
                Console.WriteLine("You have 21 days to sell as much lemonade as you can!");
                //send response to timer and make 21 day limit parameters
            }
            else
            {
                Console.WriteLine("Invalid Input, please try again.");
                DetermineNumberOfPlayDays();
            }
        }
    //public void DisplayMenuItems()
    // {
    //    Console.WriteLine($"Lemons: {lemonCount}, Ice Cubes: {iceCubeCount}, Cups of Sugar: {sugarCount}, Cups: {cupCount}.");
    //   Console.WriteLine("Day #");
    //    Console.WriteLine($"Money: ${playerMoney}");
    //   Console.WriteLine("Display: displaytemperatureOfTheDay");
    //    Console.WriteLine("Display: forecastOFTheDay");
    // }
    /*     public void OfferPurchases()
              {
           Console.WriteLine("Do you want to make a purchase? Enter: 1 - Cups, 2 - Lemons, 3 - Sugar, 4 - Ice Cubes. Or Enter 5 to Continue to Recipe");
           int purchaseChoice = int.Parse(Console.ReadLine());
           if (purchaseChoice == 1)
           {
               BuyCups();
               OfferPurchases();
           }
           else if (purchaseChoice == 2)
           {
               BuyLemons();
               OfferPurchases();
           }
           else if (purchaseChoice == 3)
           {
               BuySugar();
               OfferPurchases();
           }
           else if (purchaseChoice == 4)
           {
               BuyIceCubes();
               OfferPurchases();
           }
           else if (purchaseChoice == 5)
           {
               Console.WriteLine("Continue to next method");
           }
           else
           {
               Console.WriteLine("Invalid Input");
               OfferPurchases();
           }
       }

       public void BuyIceCubes()
       {
           double costOf100IceCubes = .58;
           double costOf250IceCubes = 1.64;
           double costOf500IceCubes = 3.43;

           Console.WriteLine("How much ice do you want to buy: 100($.58), 250($1.64), 500($3.43) or type exit to go back.");
           string response = Console.ReadLine();

           if (response == "100")
           {

               if (playerMoney - costOf100IceCubes < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf100IceCubes;
                   iceCubeCount += 100;
                   Console.WriteLine($"You bought 100 Ice Cubes! You have {iceCubeCount} ice cubes. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "250")
           {

               if (playerMoney - costOf250IceCubes < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf250IceCubes;
                   iceCubeCount += 250;
                   Console.WriteLine($"You bought 250 Ice Cubes! You have {iceCubeCount} ice cubes. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "500")
           {

               if (playerMoney - costOf500IceCubes < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf500IceCubes;
                   iceCubeCount += 500;
                   Console.WriteLine($"You bought 500 Ice Cubes! You have {iceCubeCount} ice cubes. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "exit")
           {
               Console.WriteLine("Back to the Store!");
               OfferPurchases();
           }
           else
           {
               Console.WriteLine("Invalid Input");
               BuyIceCubes();
           }
       }


       public void BuyLemons()
       {
           double costOf10Lemons = .85;
           double costOf30Lemons = 2.07;
           double costOf75Lemons = 4.03;

           Console.WriteLine("How many lemons do you want to buy: 10($.85), 30($2.07), 75($4.03) or type exit to go back.");
           string response = Console.ReadLine();

           if (response == "10")
           {

               if (playerMoney - costOf10Lemons < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf10Lemons;
                   lemonCount += 10;
                   Console.WriteLine($"You bought 10 lemons! You have {lemonCount} lemons. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "30")
           {

               if (playerMoney - costOf30Lemons < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf30Lemons;
                   lemonCount += 30;
                   Console.WriteLine($"You bought 30 lemons! You have {lemonCount} lemons. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "75")
           {

               if (playerMoney - costOf75Lemons < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf75Lemons;
                   lemonCount += 75;
                   Console.WriteLine($"You bought 75 lemons! You have {lemonCount} lemons. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "exit")
           {
               Console.WriteLine("Back to the Store!");
               OfferPurchases();
           }
           else
           {
               Console.WriteLine("Invalid Input");
               BuyLemons();
           }
       }

       public void BuyCups()
       {
           double costOf25Cups = .88;
           double costOf50Cups = 1.68;
           double costOf100Cups = 3.18;

           Console.WriteLine("How many Cups do you want to buy: 25($.88), 50($1.68), 100($3.18) or type exit to go back.");
               string response = Console.ReadLine();
               if (response == "25")
               {

               if (playerMoney - costOf25Cups < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf25Cups;
                   cupCount += 25;
                   Console.WriteLine($"You bought 25 cups! You have {cupCount} cups. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();

               }

               }
               else if (response == "50")
               {
               if (playerMoney - costOf50Cups < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf50Cups;
                   cupCount += 50;
                   Console.WriteLine($"You bought 50 cups! You have {cupCount} cups. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();

               }

               }
               else if (response == "100")
               {

               if (playerMoney - costOf100Cups < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
                   playerMoney -= costOf100Cups;
                   cupCount += 100;
                   Console.WriteLine($"You bought 100 cups! You have {cupCount} cups. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
               else if (response == "exit")
               {
                   Console.WriteLine("Back to the Store!");
                   OfferPurchases();
               }
               else
               {
                   Console.WriteLine("Invalid Input");
                   BuyCups();
               }

       }

       public void BuySugar()
       {
           double costOf8CupsOfSugar = .58;
           double costOf20CupsOfSugar = 1.64;
           double costOf48CupsOfSugar = 3.43;

           Console.WriteLine("How many cups of sugar do you want to buy: 8($.58), 20($1.68), 48($3.43) or type exit to go back.");
           string response = Console.ReadLine();
           if (response == "8")
           {

               if (playerMoney - costOf8CupsOfSugar < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf8CupsOfSugar;
                   sugarCount += 8;
                   Console.WriteLine($"You bought 8 cups of sugar! You have {sugarCount} cups of sugar. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "20")
           {

               if (playerMoney - costOf20CupsOfSugar < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf20CupsOfSugar;
                   sugarCount += 20;
                   Console.WriteLine($"You bought 20 cups of sugar! You have {sugarCount} cups of sugar. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "48")
           {

               if (playerMoney - costOf48CupsOfSugar < 0)
               {
                   Console.WriteLine("Ope! Not enough money!");
                   OfferPurchases();
                   return;
               }
               else
               {
                   playerMoney -= costOf48CupsOfSugar;
                   sugarCount += 48;
                   Console.WriteLine($"You bought 48 cups of sugar! You have {sugarCount} cups of sugar. You have ${playerMoney}. Press Enter to continue.");
                   Console.ReadLine();
               }
           }
           else if (response == "exit")
           {
               Console.WriteLine("Back to the Store!");
               OfferPurchases();
           }
           else
           {
               Console.WriteLine("Invalid Input");
               BuySugar();
           }
       }



















       public void SetLemonadeRecipe()
       {
           DeterminePricePerCup();
           lemonsPerPitcher = DetermineLemonsPerPitcher();
           iceCubesPerCup = DetermineIceCubesPerCup();
           sugarPerPitcher = DetermineSugarPerPitcher();
           DetermineIfRecipeIsSatisfactory();
       }
       public void DetermineIfRecipeIsSatisfactory()
       {
           Console.WriteLine("Are you happy with the Recipe you have chosen? Enter: yes or no.");
           string response = Console.ReadLine();
           if (response == "yes")
           {
               Console.WriteLine("Press Enter to Continue.");
           }
           else if (response == "no")
           {
               lemonsPerPitcher = 0;
               iceCubesPerCup = 0;
               sugarPerPitcher = 0;
               SetLemonadeRecipe();
           }
           else
           {
               Console.WriteLine("Invalid Input");
               DetermineIfRecipeIsSatisfactory();
           }
       }
       public int DetermineLemonsPerPitcher()
       {
           int lemonsPerPitcher;
           Console.WriteLine("How many Lemons per Pitcher?");
           lemonsPerPitcher = int.Parse(Console.ReadLine());
           return lemonsPerPitcher;
       }
       public int DetermineSugarPerPitcher()
       {
           int sugarPerPitcher;
           Console.WriteLine("How many Cups of sugar per Pitcher?");
           sugarPerPitcher = int.Parse(Console.ReadLine());
           return sugarPerPitcher;
       }
       public int DetermineIceCubesPerCup()
       {
           int iceCubesPerCup;
           Console.WriteLine("How many Ice Cubes per Cup?");
           iceCubesPerCup = int.Parse(Console.ReadLine());
           return iceCubesPerCup;
       }
       public void DisplayLemonadeRecipe()
       {
           Console.WriteLine("");
           Console.WriteLine($"Lemons Per Pitcher: {lemonsPerPitcher}");
           Console.WriteLine($"Cups of Sugar Per Pitcher: {sugarPerPitcher}");
           Console.WriteLine($"Total # of Cups {cupCount}");
           Console.WriteLine($"Ice Cubes per Cup: {iceCubesPerCup}");
       }
       public double DeterminePricePerCup()
       {
           Console.WriteLine("How much do you want to charge per cup of lemonade?");
           pricePerCup = double.Parse(Console.ReadLine());
           return pricePerCup;
       }
                       */
    
    }
}

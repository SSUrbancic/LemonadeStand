using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //members(HAS A)
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int iceCubesPerCup;
        public double playerMoney = 20;

        //Constructor
        public Game()
        {
            DisplayInstructions();
            DetermineNumberOfPlayDays();
            DisplayMenuItems();
            OfferPurchases();
            SetLemonadeRecipe();
            DisplayLemonadeRecipe();
        }
        //Methods(CAN DO)

        public void DisplayInstructions()
        {
            Console.WriteLine("Make some lemonade and sell it.");
        }

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
                //send response to timer and make 7 day limit parameters
            }
            else if (numberOfDays == 21)
            {
                Console.WriteLine("You have 21 days to sell as much lemonade as you can!");
                //send response to timer and make 7 day limit parameters
            }
            else
            {
                Console.WriteLine("Invalid Input, please try again.");
                DetermineNumberOfPlayDays();
            }


        }
        public void DisplayMenuItems()
        {
            Console.WriteLine("Lemons: {lemonCount} Ice Cubes: {iceCubeCount} Cups of Sugar: {sugarCount} Cups: {cupCount}");
            Console.WriteLine("Day #");
            Console.WriteLine($"Money: ${playerMoney}");
            Console.WriteLine("Display: displaytemperatureOfTheDay");
            Console.WriteLine("Display: forecastOFTheDay");
        }
        public void OfferPurchases()
        {
            Console.WriteLine("Do you want to make a purchase? Enter: 1 - Cups, 2 - Lemons, 3 - Sugar, 4 - Ice Cubes. Or Enter 5 to Continue to Recipe");
            int purchaseChoice = int.Parse(Console.ReadLine());
            if (purchaseChoice == 1)
            {
                Console.WriteLine("Enter Ice Buying method");
                OfferPurchases();
            }
            else if (purchaseChoice == 2)
            {
                Console.WriteLine("Enter Lemon buying method");
                OfferPurchases();
            }
            else if (purchaseChoice == 3)
            {
                Console.WriteLine("Enter sugar buying method");
                OfferPurchases();
            }
            else if (purchaseChoice == 4)
            {
                Console.WriteLine("Enter Ice Cubes buying method");
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

        public void SetLemonadeRecipe()
        {
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
            Console.WriteLine($"Lemons Per Pitcher: {lemonsPerPitcher}");
            Console.WriteLine($"Cups of Sugar Per Pitcher: {sugarPerPitcher}");
            Console.WriteLine("Total # of Cups {cupsInInventory}");
            Console.WriteLine($"Ice Cubes per Cup: {iceCubesPerCup}");
        }
    }
}

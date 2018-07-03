using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //MEMBER (HAS A)
        public int lemonsPerPitcher;
        public int sugarPerPitcher;
        public int iceCubesPerCup;
        public double pricePerCup;

        //CONSTRUCTOR
        public Recipe()
        {

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
        //METHODS (CAN DO)

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
        public double DeterminePricePerCup()
        {
            Console.WriteLine("How much do you want to charge per cup of lemonade?");
            pricePerCup = double.Parse(Console.ReadLine());
            return pricePerCup;
        }
    }
}

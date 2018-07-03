using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {//MEMBERS (HAS A)
        Player playerOne;
        Weather weather;


    //CONSTRUCTOR
        public UserInterface(Player playerOne, Weather weather)
    {
            this.playerOne = playerOne;
            this.weather = weather;
    }

        //METHODS(CAN DO)
        public void DisplayInstructions()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand. Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.Start with the basic recipe, but try to vary the recipe and see if you can do better.Lastly, set your price and sell your lemonade at the stand. Try changing up the price based on the weather conditions as well.At the end of the game, you'll see how much money you made. Write it down and play again to try and beat your score!");

        }
        public void DisplayMenuItems()
        {
            Console.WriteLine($"Inventory: Lemons: {playerOne.lemonCount}, Ice Cubes: {playerOne.iceCubeCount}, Cups of Sugar: {playerOne.sugarCount}, Cups: {playerOne.cupCount}.");
            Console.WriteLine($"Money: ${playerOne.playerMoney}");
            Console.WriteLine($"Today's temperature: {weather.actualTemperature} degrees.");
            Console.WriteLine($"Today's forecast is: {weather.actualWeather}");
        }
        public void DisplayLemonadeRecipe()
        {
            Console.WriteLine("");
            Console.WriteLine($"Lemons Per Pitcher: {playerOne.lemonadeRecipe.lemonsPerPitcher}");
            Console.WriteLine($"Cups of Sugar Per Pitcher: {playerOne.lemonadeRecipe.sugarPerPitcher}");
            Console.WriteLine($"Total # of Cups {playerOne.cupCount}");
            Console.WriteLine($"Ice Cubes per Cup: {playerOne.lemonadeRecipe.iceCubesPerCup}");
        }
    }
}

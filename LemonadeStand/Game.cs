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

        public int numberOfGameDays;
        IceCubes iceCubes;
        Lemons lemons;
        Sugar sugar;
        Cups cups;
        Player playerOne;
        Store itemStore;
        UserInterface userInterface;

        //Constructor

        public Game()
        {
            iceCubes = new IceCubes();
            lemons = new Lemons();
            sugar = new Sugar();
            cups = new Cups();
            playerOne = new Player();
            itemStore = new Store(iceCubes, lemons, cups, sugar, playerOne);
            userInterface = new UserInterface(playerOne);
        }

        //Methods(Can Do)
        
        public void RunGame() {
            userInterface.DisplayInstructions();
            DetermineNumberOfPlayDays();
            userInterface.DisplayMenuItems();
            itemStore.OfferPurchases();
            playerOne.lemonadeRecipe.SetLemonadeRecipe();
        }
        void DetermineNumberOfPlayDays()
        {
            Console.WriteLine("How many days do you want to play for? Enter 7, 14, or 21");
            int numberOfDays = int.Parse(Console.ReadLine());

            if (numberOfDays == 7)
            {
                Console.WriteLine("You have 7 days to sell as much lemonade as you can!");
                numberOfGameDays = 7;
                //send response to timer and make 7 day limit parameters
            }
            else if (numberOfDays == 14)
            {
                Console.WriteLine("You have 14 days to sell as much lemonade as you can!");
                numberOfGameDays = 14;
                //send response to timer and make 14 day limit parameters
            }
            else if (numberOfDays == 21)
            {
                Console.WriteLine("You have 21 days to sell as much lemonade as you can!");
                numberOfGameDays = 21;
                //send response to timer and make 21 day limit parameters
            }
            else
            {
                Console.WriteLine("Invalid Input, please try again.");
                DetermineNumberOfPlayDays();
            }
        }
    }
}






  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //MEMBERS (HAS A)
        IceCubes iceCubes;
        Lemons lemons;
        Cups cups;
        Sugar sugar;
        Player playerOne;


        //Constructor
        public Store(IceCubes iceCubes, Lemons lemons, Cups cups, Sugar sugar, Player playerOne)
        {
            this.iceCubes = iceCubes;
            this.cups = cups;
            this.sugar = sugar;
            this.lemons = lemons;
            this.playerOne = playerOne;
        }

        //METHODS(CAN DO)
        public void OfferPurchases()
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
                Console.WriteLine("Set your: Price Per Cup, lemons per pitcher, Ice Per Cup, and Sugar per pitcher.");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                OfferPurchases();
            }
        }
        public void BuyIceCubes()
        {
            Console.WriteLine("How much ice do you want to buy: 100($.58), 250($1.64), 500($3.43) or type exit to go back.");
            string response = Console.ReadLine();

            if (response == "100")
            {

                if (playerOne.playerMoney - iceCubes.costOf100IceCubes < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= iceCubes.costOf100IceCubes;
                    playerOne.iceCubeCount += 100;
                    Console.WriteLine($"You bought 100 Ice Cubes! You have {playerOne.iceCubeCount} ice cubes. You have ${playerOne.playerMoney}. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else if (response == "250")
            {

                if (playerOne.playerMoney - iceCubes.costOf250IceCubes < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= iceCubes.costOf250IceCubes;
                    playerOne.iceCubeCount += 250;
                    Console.WriteLine($"You bought 250 Ice Cubes! You have {playerOne.iceCubeCount} ice cubes. You have ${playerOne.playerMoney}. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else if (response == "500")
            {

                if (playerOne.playerMoney - iceCubes.costOf500IceCubes < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= iceCubes.costOf500IceCubes;
                    playerOne.iceCubeCount += 500;
                    Console.WriteLine($"You bought 500 Ice Cubes! You have {playerOne.iceCubeCount} ice cubes. You have ${playerOne.playerMoney}. Press Enter to continue.");
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
            Console.WriteLine("How many lemons do you want to buy: 10($.85), 30($2.07), 75($4.03) or type exit to go back.");
            string response = Console.ReadLine();

            if (response == "10")
            {

                if (playerOne.playerMoney - lemons.costOf10Lemons < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= lemons.costOf10Lemons;
                    playerOne.lemonCount += 10;
                    Console.WriteLine($"You bought 10 lemons! You have {playerOne.lemonCount} lemons. You have ${playerOne.playerMoney }. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else if (response == "30")
            {

                if (playerOne.playerMoney - lemons.costOf30Lemons < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= lemons.costOf30Lemons;
                    playerOne.lemonCount += 30;
                    Console.WriteLine($"You bought 30 lemons! You have {playerOne.lemonCount} lemons. You have ${playerOne.playerMoney }. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else if (response == "75")
            {

                if (playerOne.playerMoney - lemons.costOf75Lemons < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= lemons.costOf75Lemons;
                    playerOne.lemonCount += 75;
                    Console.WriteLine($"You bought 75 lemons! You have {playerOne.lemonCount} lemons. You have ${playerOne.playerMoney }. Press Enter to continue.");
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

                if (playerOne.playerMoney - costOf25Cups < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= costOf25Cups;
                    playerOne.cupCount += 25;
                    Console.WriteLine($"You bought 25 cups! You have {playerOne.cupCount} cups. You have ${playerOne.playerMoney}. Press Enter to continue.");
                    Console.ReadLine();

                }

            }
            else if (response == "50")
            {
                if (playerOne.playerMoney - costOf50Cups < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= costOf50Cups;
                    playerOne.cupCount += 50;
                    Console.WriteLine($"You bought 50 cups! You have {playerOne.cupCount} cups. You have ${playerOne.playerMoney}. Press Enter to continue.");
                    Console.ReadLine();

                }

            }
            else if (response == "100")
            {

                if (playerOne.playerMoney - costOf100Cups < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                playerOne.playerMoney -= costOf100Cups;
                playerOne.cupCount += 100;
                Console.WriteLine($"You bought 100 cups! You have {playerOne.cupCount} cups. You have ${playerOne.playerMoney}. Press Enter to continue.");
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

                if (playerOne.playerMoney - costOf8CupsOfSugar < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= costOf8CupsOfSugar;
                    playerOne.sugarCount += 8;
                    Console.WriteLine($"You bought 8 cups of sugar! You have {playerOne.sugarCount} cups of sugar. You have ${playerOne.playerMoney}. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else if (response == "20")
            {

                if (playerOne.playerMoney - costOf20CupsOfSugar < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= costOf20CupsOfSugar;
                    playerOne.sugarCount += 20;
                    Console.WriteLine($"You bought 20 cups of sugar! You have {playerOne.sugarCount} cups of sugar. You have ${playerOne.playerMoney}. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
            else if (response == "48")
            {

                if (playerOne.playerMoney - costOf48CupsOfSugar < 0)
                {
                    Console.WriteLine("Ope! Not enough money!");
                    OfferPurchases();
                    return;
                }
                else
                {
                    playerOne.playerMoney -= costOf48CupsOfSugar;
                    playerOne.sugarCount += 48;
                    Console.WriteLine($"You bought 48 cups of sugar! You have {playerOne.sugarCount} cups of sugar. You have ${playerOne.playerMoney}. Press Enter to continue.");
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface

    {
     
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                System.Threading.Thread.Sleep(300);
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static void GameInstructions()
        {
            Console.WriteLine("Loading.............");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Welcome to your lemonade stand!\nYou will have either 7, 14, or 30 days to make the most profit as possible!\nYou'll have complete control over your buisness, including pricing, quality control, inventory control, and purchasing supplies.\nBuy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("First thing you'll have to worry about is your recipe, make sure you buy enough of all your ingredients, or you won't be able to sell.");
            Console.WriteLine("Each customer has there own preference on Sugar, Lemons, Temperature, and Price they're willing to pay.\nOh an your ice melts after every day!");
            Console.WriteLine("Good Luck, And Have Fun!");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static int AmountOfLemons(Inventory inventory)
        {
            Console.WriteLine("Please enter the number of lemons for your secret recipe!");
            int amountOfLemons = Convert.ToInt32(Console.ReadLine().Trim());
            System.Threading.Thread.Sleep(300);
            if (amountOfLemons <= inventory.lemons.Count) 
            {
                return amountOfLemons;
            }
            else
            {
                return AmountOfLemons(inventory);
            }
        }

        public static int AmountOfSugarCubes(Inventory inventory)
        {
            Console.WriteLine("Time to make our secret recipe!");
            Console.WriteLine("Please enter the number of sugarcubes for your secret recipe!");
            int amountOfSugarCubes = Convert.ToInt32(Console.ReadLine().Trim());
            System.Threading.Thread.Sleep(300);
            if (amountOfSugarCubes <= inventory.sugarCubes.Count)
            {
                return amountOfSugarCubes;
            }
            else
            {
                return AmountOfSugarCubes(inventory);
            }
        }

        public static int AmountOfIceCubes(Inventory inventory)
        {
            Console.WriteLine("Please enter the number of ice cubes per cup for your secret recipe!");
            int amountOfIceCubes = Convert.ToInt32(Console.ReadLine().Trim());
            System.Threading.Thread.Sleep(300);
            if (amountOfIceCubes <= inventory.iceCubes.Count)
            {
                return amountOfIceCubes;
            }
            else
            {
                return AmountOfIceCubes(inventory);
            }
        }

        public static double PricePerCup(Inventory inventory)
        {
            Console.WriteLine("Please enter your price per cup!\n for example 1.00 or .20");
            double pricePerCup = Convert.ToDouble(Console.ReadLine().Trim());
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            return pricePerCup;
        }

        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("You currently have " + inventory.lemons.Count + " lemons");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("You currently have " + inventory.sugarCubes.Count + " sugarcubes");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("You currently have " + inventory.iceCubes.Count + " icecubes");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("You currently have " + inventory.cups.Count + " cups");
            System.Threading.Thread.Sleep(300);

        }

        public static double StoreMenu(Player player, Store store)
        {
            string storeRef = " ";
            double amountSpent = 0;
            while(storeRef != "")
            {
                DisplayMoney(player);
                Console.WriteLine("Welcome to the good ole store what would you like to purchase?\nPlease enter one of the following you would like to purchase.\nLemons/Sugar/Cubes/Cups/ start to start game or quit to exit game.");
                System.Threading.Thread.Sleep(1000);
                storeRef = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                switch (storeRef)
                {
                    case "lemons":
                        Console.WriteLine("Lemons are currently $ " + store.PricePerLemon + " each.");
                        System.Threading.Thread.Sleep(300);
                        amountSpent += store.SellLemons(player);
                        break;
                    case "sugar":
                        Console.WriteLine("SugarCubes are currently $ " + store.PricePerSugarCube + " each.");
                        System.Threading.Thread.Sleep(300);
                        amountSpent += store.SellSugarCubes(player);
                        break;
                    case "cubes":
                        Console.WriteLine("IceCubes are currently $ " + store.PricePerIceCube + " each.");
                        System.Threading.Thread.Sleep(300);
                        amountSpent += store.SellIceCubes(player);
                        break;
                    case "cups":
                        Console.WriteLine("Cups are currently $ " + store.PricePerCup + " each.");
                        System.Threading.Thread.Sleep(300);
                        amountSpent += store.SellCups(player);
                        break;
                    case "start":
                        storeRef = "";
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please try again and enter a valid item");
                        System.Threading.Thread.Sleep(300);
                        return StoreMenu(player, store);
                }
            }
            return amountSpent;
        }

        public static void DisplayMoney(Player player)
        {
            Console.WriteLine("You currently have $ " + player.wallet.Money);
            System.Threading.Thread.Sleep(1000);
        }

        public static void DisplayPopularity(Day day)
        {
            Console.WriteLine("Today you had a total of " + day.customers.Count + " potential customers pass by your stand.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Out of " + day.customers.Count + " potential customers, " + day.customersBought + " bought your lemonade.");
            System.Threading.Thread.Sleep(1000);
        }

        public static void DisplayDailyIncome(Day day)
        {
            Console.WriteLine("Your daily income was $ " + day.dailyIncome);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your daily profit was $ " + day.moneyProfit);
            Console.WriteLine("Hit Enter To Continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void EndGameCredits(double endProfit,int totDays)//Single Respomsibility Principle
        {
            Console.WriteLine("Your total profit after " + totDays + " days was: $ " + endProfit);
            System.Threading.Thread.Sleep(1000);
        }

        public static int DaysPlaying()
        {
            try
            {
                Console.WriteLine("Please enter the amount of days you would like to play\nEither 7/14/30");
                int numDays = Convert.ToInt32(Console.ReadLine().Trim());
                switch (numDays)
                {
                    case 7:
                    case 14:
                    case 30:
                        return numDays;
                    default:
                        Console.WriteLine("Invalid amount of days, please retry.");
                        System.Threading.Thread.Sleep(1000);
                        return DaysPlaying();

                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a valid amount of days.");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                return DaysPlaying();
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Please enter a valid amount of days.");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                return DaysPlaying();
            }

        }

        public static void WeatherForcast(int forcast)
        {
            Console.WriteLine("Todays Weather will be a low of " + (forcast - 10));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Along with a high of " + (forcast + 10));
            System.Threading.Thread.Sleep(1000);
        }

        public static string PlayAgain()
        {
            Console.WriteLine("Would you like to try again?!\nYes or No");
            string answer = Console.ReadLine().ToLower().Trim();
            return answer;
        }

    }
}

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
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        public static void GameInstructions()
        {

            Console.WriteLine("Welcome to your lemonade stand!\nYou will have 7 days to make the most profit as possible!\nYou'll have complete control over your buisness, including pricing, quality control, inventory control, and purchasing supplies.\nBuy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("First thing you'll have to worry about is your recipe, make sure you buy enough of all your ingredients, or you won't be able to sell.");
            Console.WriteLine("You'll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade, so make sure to read the weather report every day!");
            Console.WriteLine("When the temperature drops, or the weather turns bad (overcast, cloudy, rain), don't expect them to buy nearly as much as the would on a hot, hazy day, so buy accoringly\nFeel free to set your prices higher on those hot, muggy days too, as you'll make more profit, even if you sell a bit less lemonade.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static int AmountOfLemons(Inventory inventory)
        {
            Console.WriteLine("Please enter the number of lemons for your secret recipe!");
            int amountOfLemons = Convert.ToInt32(Console.ReadLine().Trim());
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
            Console.WriteLine("Please enter your price per cup!");
            double pricePerCup = Convert.ToDouble(Console.ReadLine().Trim());
            return pricePerCup;
        }

        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("You currently have " + inventory.lemons.Count + " lemons");
            Console.WriteLine("You currently have " + inventory.sugarCubes.Count + " sugarcubes");
            Console.WriteLine("You currently have " + inventory.iceCubes.Count + " icecubes");
            Console.WriteLine("You currently have " + inventory.cups.Count + " cups");
            
        }

        public static double StoreMenu(Player player, Store store)
        {
            string storeRef = " ";
            double amountSpent = 0;
            while(storeRef != "")
            {
                Console.WriteLine("Welcome to the good ole store what would you like to purchase?\nPlease enter one of the following you would like to purchase.\nLemons/Sugar/Cubes/Cups/ start to start game or quit to exit game.");
                 storeRef = Console.ReadLine().ToLower().Trim();
                switch (storeRef)
                {
                    case "lemons":
                        Console.WriteLine("Lemons are currently $ " + store.PricePerLemon + " each.");
                        amountSpent += store.SellLemons(player);
                        break;
                    case "sugar":
                        Console.WriteLine("SugarCubes are currently $ " + store.PricePerSugarCube + " each.");
                        amountSpent += store.SellSugarCubes(player);
                        break;
                    case "cubes":
                        Console.WriteLine("IceCubes are currently $ " + store.PricePerIceCube + " each.");
                        amountSpent += store.SellIceCubes(player);
                        break;
                    case "cups":
                        Console.WriteLine("Cups are currently $ " + store.PricePerCup + " each.");
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
                        break;
                }
            }
            return amountSpent;
        }

        public static void DisplayMoney(Player player)
        {
            Console.WriteLine("You currently have $ " + player.wallet.Money);
        }

        public static void DisplayPopularity(Day day)
        {
            Console.WriteLine("Today you had a total of " + day.customers.Count + " pass by your stand.");
            Console.WriteLine("Out of " + day.customers.Count + ", only " + day.customersBought + " bought your lemonade.");
        }

        public static void DisplayDailyIncome(Day day)
        {
            Console.WriteLine("Your daily income was $ " + day.dailyIncome);
        }


    }
}

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

        public static int AmountOfLemons()
        {
            Console.WriteLine("Please enter the number of lemons for your secret recipe!");
            int amountOfLemons = Convert.ToInt32(Console.ReadLine().Trim());
            return amountOfLemons;
        }

        public static void GameInstructions()
        {

            Console.WriteLine("Welcome to your lemonade stand!\nYou will have 7 days to make as much profit possible!\nYou'll have complete control over you buisness, including pricing, quality control, inventory control, and purchasing supplies.\nBuy you ingredients, set your recipe, and start selling!");
            Console.WriteLine("First thing you'll have to worry about is your recipe, make sure you buy enough of all your ingredients, or you won't be able to sell.");
            Console.WriteLine("You'll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade, so make sure to read the weather report every day!");
            Console.WriteLine("When the temperature drops, or the weather turns bad (overcast, cloudy, rain), don't expect them to buy nearly as much as the would on a hot, hazy day, so buy accoringly\nFeel free to set your prices higher on those hot, muggy days too, as you'llmake more profit, even if you sell a bit less lemonade.");

        }


    }
}

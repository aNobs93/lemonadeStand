using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {

        }

        public void AmountOfLemons()
        {
             amountOfLemons = UserInterface.AmountOfLemons();

            //Console.WriteLine("Please enter the number of lemons for your secret recipe!");
            //amountOfLemons = Convert.ToInt32(Console.ReadLine().Trim());
        }

        public void AmountOfSugarCubes()
        {
            Console.WriteLine("Please enter the number of sugarcubes for your secret recipe!");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine().Trim());
        }

        public void AmountOfIceCubes()
        {
            Console.WriteLine("Please enter the number of ice cubes per cup for your secret recipe!");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine().Trim());
        }

        public void PricePerCup()
        {
            Console.WriteLine("Please enter your price per cup!");
            pricePerCup = Convert.ToInt32(Console.ReadLine().Trim());
        }

    }
}

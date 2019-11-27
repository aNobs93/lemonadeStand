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
        Inventory inventory;

        public Recipe(Inventory inventory) => this.inventory = inventory;
        public void SetUpRecipe()
        {
            AmountOfSugarCubes();
            AmountOfLemons();
            AmountOfIceCubes();
            PricePerCup();
        }
        public void AmountOfLemons() => amountOfLemons = UserInterface.AmountOfLemons(inventory);//Console.WriteLine("Please enter the number of lemons for your secret recipe!");//amountOfLemons = Convert.ToInt32(Console.ReadLine().Trim());

        public void AmountOfSugarCubes() => amountOfSugarCubes = UserInterface.AmountOfSugarCubes(inventory);

        public void AmountOfIceCubes() => amountOfIceCubes = UserInterface.AmountOfIceCubes(inventory);

        public void PricePerCup() => pricePerCup = UserInterface.PricePerCup(inventory);

    }
}

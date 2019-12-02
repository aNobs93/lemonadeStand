using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        public int cupsLeftInPitcher;

        public Pitcher()
        {
            cupsLeftInPitcher = 0;

        }


        public void CreatePitcher(Recipe recipe, Inventory inventory)
        {
            if (inventory.lemons.Count >= recipe.amountOfLemons && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && inventory.iceCubes.Count >= (recipe.amountOfIceCubes * 15))
            {
                inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
                inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
                inventory.iceCubes.RemoveRange(0, 15 * recipe.amountOfIceCubes);
                cupsLeftInPitcher = 15;
            }
        }
    }
}
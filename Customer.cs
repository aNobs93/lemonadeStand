using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        private List<string> names = new List<string>() {"Pikachu", "Mewtwo", "Eevee", "Celebi", "Ditto", "Snorlax", "Charizard", "Mew", "Charmander", "Gengar", "Bulbasaur", "Rayquaza", "Squirtle", "Dragonite", "Jigglypuff", "Magikarp", "Raichu", "Psyduck", "Pichu", "Vulpix", "Blastoise", "Slowpoke", "Mudkip", "Entei", "Lapras", "Togepi", "Geodude", "Diglett", "Machamp", "Legia"};
        public string name;
        Random rnd = new Random();
        int lemonPref;
        int sugarPref;
        int tempPref;

        public Customer()
        {
            ChooseName();
            CustomerPref();
        }

        public void ChooseName()
        {
            int n = rnd.Next(0, 29);
            name = names[n];
         
        }

        public void CustomerPref()
        {
            lemonPref = rnd.Next(0, 10);
            sugarPref = rnd.Next(0, 10);
            tempPref = rnd.Next(30, 110);

        }

        public bool DidCustomerBuy(Recipe recipe, Weather weather)
        {
            if(recipe.amountOfLemons >= lemonPref - 3 && recipe.amountOfSugarCubes >= sugarPref -3 && weather.temperature >= tempPref - 20 && weather.temperature <= tempPref + 20)
            {
                return true;
            }
            return false;
        }
    }
}

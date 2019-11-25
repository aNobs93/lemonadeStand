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
        public void ChooseName()
        {
            int n = rnd.Next(0, 29);
            name = names[n];

        }

    }
}

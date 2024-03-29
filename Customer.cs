﻿using System;
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
        //Random rnd = new Random();
        int lemonPref;
        int sugarPref;
        int tempPref;
        Random rnd;
        double pricePref;

        public Customer(Random random)
        {
            rnd = random;
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
            lemonPref = rnd.Next(1, 10);
            sugarPref = rnd.Next(1, 10);
            tempPref = rnd.Next(30, 110);
            pricePref = rnd.Next(10, 100);
            pricePref = (pricePref / 100);
            
        }

        public bool DidCustomerBuy(Recipe recipe, Weather weather)
        {
            if((recipe.amountOfLemons == lemonPref -2 || recipe.amountOfSugarCubes == sugarPref -2) && (weather.temperature >= tempPref - 20 || weather.temperature >= tempPref + 20) && (recipe.pricePerCup <= pricePref) )
            {
                return true;
            }
            return false;
        }
    }
}

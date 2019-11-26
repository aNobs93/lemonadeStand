using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        private Store store;
        private Player player;
        private List<Day> days = new List<Day>() {};
        private int currentDay;

        public Game()
        {
            player = new Player();
            store = new Store();
        }

        public void RunGame()
        {
            UserInterface.GameInstructions();
            UserInterface.DisplayInventory(player.inventory);
            store.SellLemons(player);
            
            
        }


    }
}

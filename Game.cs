using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        private Random random;
        private Store store;
        private Player player;
        private List<Day> days = new List<Day>() {};
        private int currentDay;
        private double endIncome;
        private double endProfit;

        public Game()
        {
            endProfit = 0;
            random = new Random();
            player = new Player();
            store = new Store();
        }
        public void BuildDays()
        {
            for (int i = 0; i < 7; i++)
			{
                Day day = new Day(random);
                days.Add(day);

			}
        }
        public void RunGame()
        {
            UserInterface.GameInstructions();
            BuildDays();
               for (int i = 0; i < 7; i++)
			{
            
                days[i].RunDay(player, store, days[i], player.recipe, player.inventory, random);
                endProfit += days[i].DailyProfit(player);

			}
            UserInterface.EndGameCredits(endProfit);
            
        }


    }
}

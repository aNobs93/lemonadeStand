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
        private List<Day> days = new List<Day>() { };
        private List<int> forcast = new List<int>() { };
        private int currentDay;
        private double endProfit;
        private int DaysPlaying;
        private string answer;

        public Game()
        {
            endProfit = 0;
            random = new Random();
            player = new Player();
            store = new Store();
        }
        public void BuildDays()
        {
            for (int i = 0; i < DaysPlaying; i++)
            {
                Day day = new Day(random);
                days.Add(day);

            }
        }

        public void GenerateForecast()
        {
            for (int i = 0; i < days.Count; i++)
            {
                forcast.Add(days[i].weather.temperature);
            }

        }

        public int HowManyDays()
        {
            DaysPlaying = UserInterface.DaysPlaying();
            return DaysPlaying;
        }

        public void RunGame()
        {
            UserInterface.GameInstructions();
            HowManyDays();
            BuildDays();
            GenerateForecast();
            for (int i = 0; i < DaysPlaying; i++)
            {

                UserInterface.WeatherForcast(forcast[i]);
                days[i].RunDay(player, store, days[i], player.recipe, player.inventory, random);
                endProfit += days[i].DailyProfit(player);

            }
            UserInterface.EndGameCredits(endProfit);
            Retry();

        }



        public void Retry()
        {
            answer = UserInterface.PlayAgain();
            switch (answer)
            {
                case "yes":
                    RunGame();
                    break;
                default:
                    Environment.Exit(0);
                    break;

            }


        }
    }
}

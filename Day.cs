using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //public Random rnd = new Random();
        public Weather weather;
        public List<Customer> customers = new List<Customer>() { };
        public int customersBought;
        public double dailyIncome;
        public double moneyProfit;
        double dailyAmountSpent;
        public Day(Random random)
        {
            weather = new Weather(random);
        }
        public void GenerateCustomers(Random random)
        {
            int n = random.Next(60, 120);
            for(int i = 0; i < n; i++)
            {
               
                customers.Add(new Customer(random));
                
            }
        }
        public void RunDay(Player player, Store store, Day day, Recipe recipe, Inventory inventory, Random random)
        {
            UserInterface.DisplayInventory(player.inventory);
            dailyAmountSpent = UserInterface.StoreMenu(player, store);
            UserInterface.DisplayInventory(player.inventory);
            player.recipe.SetUpRecipe();
            GenerateCustomers(random);
            player.pitcher.CreatePitcher(recipe, inventory);
            SellLemonade(player, recipe, inventory);
            DailyProfit(player);
            UserInterface.DisplayPopularity(day);
            UserInterface.DisplayDailyIncome(day);
            player.inventory.iceCubes = new List<IceCube>();




        }

        public void SellLemonade(Player player, Recipe recipe, Inventory inventory)
        {
            for (int i = 0; i < customers.Count; i++)
            {

                if(customers[i].DidCustomerBuy(player.recipe, weather))
                {
                    customersBought++;
                    player.inventory.cups.RemoveRange(0, 1);
                    player.wallet.Money += player.recipe.pricePerCup;
                    if(player.pitcher.cupsLeftInPitcher == 0)
                    {
                        player.pitcher.CreatePitcher(recipe, inventory);
                        player.pitcher.cupsLeftInPitcher--;
                    }
                    if(player.pitcher.cupsLeftInPitcher == 0)
                    {
                        return;
                    }
                    player.pitcher.cupsLeftInPitcher --;
                    
                }

            }
        }

        public double DailyProfit(Player player)
        {
            dailyIncome = customersBought * player.recipe.pricePerCup;
            moneyProfit = dailyIncome - dailyAmountSpent;
            return moneyProfit;
        }


    }
}

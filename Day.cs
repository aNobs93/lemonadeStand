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
            UserInterface.DisplayMoney(player);
            UserInterface.DisplayInventory(player.inventory);
            double dailyAmoutSpent = UserInterface.StoreMenu(player, store);
            UserInterface.DisplayInventory(player.inventory);
            player.recipe.SetUpRecipe();
            GenerateCustomers(random);
            player.pitcher.CreatePitcher(recipe, inventory);
            SellLemonade(player, recipe, inventory);
            DailyProfit(player, dailyAmoutSpent);
            UserInterface.DisplayPopularity(day);
            UserInterface.DisplayDailyIncome(day);




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
                    }else
                    player.pitcher.cupsLeftInPitcher --;
                    //sell cup
                    //Need to subtract cup from pitcher
                    //Start here on monday, need to keep a running total of money showing proift or loss. i need to make it so i can't go into debt with my wallet and i need to show the popularity of my stand.
                }

            }
        }

        public void DailyProfit(Player player, double dailyAmountSpent)
        {
            dailyIncome = customersBought * player.recipe.pricePerCup;
            moneyProfit = dailyIncome - dailyAmountSpent;
        }

        //public double DailyAmountSpent(Player player, Store store)
        //{
        //    double dailyAmountSpent = UserInterface.StoreMenu(player, store);

        //    return dailyAmountSpent;


        //}

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public Random rnd = new Random();
        public Weather weather;
        public List<Customer> customers = new List<Customer>() { };
        public int customersBought;
        public double dailyIncome;
        public double MoneySpent;

        public void GenerateCustomers()
        {
            int n = rnd.Next(60, 120);
            for(int i = 0; i < n; i++)
            {
               
                customers.Add(new Customer());
                
            }
        }
        public void RunDay(Player player, Store store)
        {
            UserInterface.DisplayMoney(player);
            UserInterface.DisplayInventory(player.inventory);
            UserInterface.StoreMenu(player, store);
            UserInterface.DisplayInventory(player.inventory);
            player.recipe.SetUpRecipe();
            SellLemonade(player);




        }

        public void SellLemonade(Player player)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if(customers[i].DidCustomerBuy(player.recipe, weather))
                {
                    customersBought++;
                    player.inventory.cups.RemoveRange(0, 1);
                    player.wallet.Money += player.recipe.pricePerCup;
                    //sell cup
                    //Start here on monday, need to keep a running total of money showing proift or loss. i need to make it so i can't go into debt with my wallet and i need to show the popularity of my stand.
                }

            }
        }

        public void DailyProfit(Player player)
        {
            dailyIncome = customersBought * player.recipe.pricePerCup - DailyAmountSpent();
        }

        public double DailyAmountSpent(Store store)
        {
            double dailyAmountSpent = 5;

            return dailyAmountSpent;


        }

    }
}

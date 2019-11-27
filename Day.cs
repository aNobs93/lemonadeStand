using System;
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

        public void GenerateCustomers()
        {
            int n = rnd.Next(60, 120);
            for(int i = 0; i < n; i++)
            {
               
                customers.Add(new Customer());
                
            }
        }
        public void RunDay(Player player, Store store )
        {

            UserInterface.DisplayInventory(player.inventory);
            UserInterface.StoreMenu(player, store);
            UserInterface.DisplayInventory(player.inventory);
            UserInterface.AmountOfSugarCubes();
            UserInterface.AmountOfIceCubes();
            UserInterface.AmountOfLemons();
            
            //DAy logic here.

            //1 go to store

            //2 



        }
        public void TakeCup()
        {

        }

    }
}

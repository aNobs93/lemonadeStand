using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Store store = new Store();


            store.SellLemons(player);
        }
    }
}

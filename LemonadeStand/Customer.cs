using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        string name;
        public Customer()
        {
            name = "customer";
        }

        // method to purchase a drink
        public void Purchase(Player player, Recipe recipe)
        {
            player.inventory.cups.RemoveAt(0);
            player.wallet.AcceptMoney(recipe.price);
        }

    }
}

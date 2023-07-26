using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        string name;
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            name = "Nikita";
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        // member methods (CAN DO)

        public void DisplayInvetory()
        {
            Console.WriteLine($"You have {wallet.Money}");
            Console.WriteLine($"You have {inventory.lemons.Count}");
            Console.WriteLine($"You have {inventory.sugarCubes.Count}");
            Console.WriteLine($"You have {inventory.iceCubes.Count}");
            Console.WriteLine($"You have {inventory.cups.Count}");
        }

        public void ChangeRecipe()
        {
            Console.WriteLine("Enter number of Lemons:");
            recipe.numberOfLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Sugar Cubes:");
            recipe.numberOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Ice Cubes:");
            recipe.numberOfIceCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a price:");
            recipe.price = Convert.ToInt32(Console.ReadLine());
        }
    }
}

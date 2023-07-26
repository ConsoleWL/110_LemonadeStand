using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public int drinksAvailable;
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
            Console.WriteLine($"\nYou have ${wallet.Money}");
            Console.WriteLine($"You have {inventory.lemons.Count} lemons");
            Console.WriteLine($"You have {inventory.sugarCubes.Count} sugar cubes");
            Console.WriteLine($"You have {inventory.iceCubes.Count} ice cubes");
            Console.WriteLine($"You have {inventory.cups.Count} cups\n");
        }

        public void InventoryAfterMakingPitcher(int amountOfPitchers)
        {
            // 1 pitcher = 8 cups.
            int cups = 8 * amountOfPitchers;

            int lemonsForPitcher = recipe.numberOfLemons * 8;
            int sugarForPitcher = recipe.numberOfSugarCubes * 8;
            int iceForPitcher = recipe.numberOfIceCubes * 8;

            inventory.lemons.RemoveRange(inventory.lemons.Count -1, lemonsForPitcher);
            inventory.sugarCubes.RemoveRange(inventory.sugarCubes.Count -1, sugarForPitcher);
            inventory.iceCubes.RemoveRange(inventory.sugarCubes.Count - 1, iceForPitcher);  
        }
  
    }
}

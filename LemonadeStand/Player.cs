using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public int drinksAvailable;
        public int drinksSold = 0;
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

        public void MakeAPitcher(int amountOfPitchers)
        {
            // 1 pitcher = 8 cups.
            drinksAvailable = 8 * amountOfPitchers;

            int lemonsForPitcher = recipe.numberOfLemons * amountOfPitchers;
            int sugarForPitcher = recipe.numberOfSugarCubes * amountOfPitchers;
            int iceForPitcher = recipe.numberOfIceCubes * amountOfPitchers;

            inventory.lemons.RemoveRange(0, lemonsForPitcher);
            inventory.sugarCubes.RemoveRange(0, sugarForPitcher);
            inventory.iceCubes.RemoveRange(0, iceForPitcher);  
        }
  
    }
}

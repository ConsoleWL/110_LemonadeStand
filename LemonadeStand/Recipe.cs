using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double price;
        public string name;

        // constructor (SPAWNER)
        public Recipe()
        {
            name = "Regular Lemonade";
            numberOfLemons = 2;
            numberOfSugarCubes = 5;
            numberOfIceCubes = 10;
            price = 2;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"\nYour recipe {name} price ${price} and consists " +
                $"of:\n{numberOfLemons} lemons per pitcher\n{numberOfSugarCubes} " +
                $"sugar cubes per pitcher\n{numberOfIceCubes} ice cubes per pitcher");
        }

        public void ChangeRecipe()
        {
            Console.WriteLine("\nYou'd you like to change your recipe? Y/N");
            string answer = Console.ReadLine();
            if(answer == "Y")
            {
                Console.WriteLine("Enter a name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter number of Lemons:");
                numberOfLemons = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of Sugar Cubes:");
                numberOfSugarCubes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of Ice Cubes:");
                numberOfIceCubes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a price:");
                price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSuccessfuly saved");
                DisplayRecipe();
            }
            else if(answer == "N")
            {

            }
            else
            {
                Console.WriteLine("Invalid input");
            } 
        }
    }
}

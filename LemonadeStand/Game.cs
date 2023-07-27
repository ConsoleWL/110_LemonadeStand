using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Random rnd = new Random();
        int currentDay;

        Player player;
        Store store;
        List<Day> days;
        List<Customer> customers;
        

        public Game()
        {
            currentDay = 1;
            player = new Player();
            store = new Store();
            customers = new List<Customer>();
            
            days = new List<Day>();
            days.Add(new Day());
            days.Add(new Day());
            days.Add(new Day());
            days.Add(new Day());
            days.Add(new Day());
            days.Add(new Day());
            days.Add(new Day());
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("You have 7 days to make as much money as you can.");
            Console.WriteLine("The weather, along with your pricing, can affect your success.");
            Console.WriteLine("Can you make the big bucks");
        }

        public void DisplayProfitLoss()
        {
            Console.WriteLine($"\nDay {currentDay} is over! You sold {player.drinksSold} cups, which brought in ${player.drinksSold * player.recipe.price}");
        }

        public void GenerateCustomers()
        {

            switch (days[currentDay - 1].weather.condition)
            {
                case "perfect":
                    for (int i = 0; i < 100; i++)
                    {
                        customers.Add(new Customer());
                    }
                    break;
                case "good":
                    for (int i = 0; i < 60; i++)
                    {
                        customers.Add(new Customer());
                    }
                    break;
                case "bad":
                    for (int i = 0; i < 30; i++)
                    {
                        customers.Add(new Customer());
                    }
                    break;
            }
        }

        public void CustomersPurchase()
        {
            
            for (int i = 0; i < customers.Count; i++)
            {

                if (player.drinksAvailable > 0)
                {
                    if (player.inventory.cups.Count > 0)
                    {
                        int random = rnd.Next(1, 6);

                        if (random == 1 || random == 2 || random == 3)
                        {
                            Console.WriteLine("A customer walks by...");
                        }
                        else
                        {
                            customers[i].Purchase(player, player.recipe);
                            Console.WriteLine($"A customer buys a cup of {player.recipe.name}");
                            player.drinksSold++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough cups...Run out of cups!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Sold out!");
                }
            }
        }
        
        public void GameSimulation()
        {
            while (currentDay < 8)
            {
                Console.WriteLine($"\nDay {currentDay} begins!");

                player.DisplayInvetory();

                store.SellLemons(player);
                store.SellSugarCubes(player);
                store.SellIceCubes(player);
                store.SellCups(player);

                player.recipe.DisplayRecipe();
                player.recipe.ChangeRecipe();

                days[currentDay].weather.DisplayTemperature();

                int amountOfPitchers = UserInterface.GetNumberOfPitchers();

                player.MakeAPitcher(amountOfPitchers);

                GenerateCustomers();

                CustomersPurchase();

                DisplayProfitLoss();

                currentDay++;
            }
        }

        public void GameRuslts()
        {

        }

        public void RunGame()
        {
            GameSimulation();
            Welcome();
            GameRuslts();
        }

    }
}

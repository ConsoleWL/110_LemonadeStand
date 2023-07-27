using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

            days = new List<Day>
            {
                new Day(),
                new Day(),
                new Day(),
                new Day(),
                new Day(),
                new Day()
            };
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("You have 7 days to make as much money as you can.");
            Console.WriteLine("The weather, along with your pricing, can affect your success.");
            Console.WriteLine("Can you make the big bucks");
        }

        public void WhetherRandonizer()
        {
            int changeWeather = rnd.Next(1, 7);
            if (changeWeather == 1)
            {
                //then well change it
                if (days[currentDay].weather.condition == "perfect")
                {
                    days[currentDay].weather.condition = "bad";
                }
                else if (days[currentDay].weather.condition == "bad")
                {
                    days[currentDay].weather.condition = "perfect";

                }
                else
                {
                    days[currentDay].weather.condition = "perfect";
                }
            }
        }

        public void GenerateCustomers()
        {
            WhetherRandonizer();

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
                    int random = rnd.Next(1, 6);

                    if (random == 1 || random == 2 || random == 3)
                    {
                        Console.WriteLine("A customer walks by...");
                    }
                    else
                    {
                        customers[i].Purchase(player, player.recipe);
                        Console.WriteLine($"A customer buys a cup of {player.recipe.name}");

                        player.drinksAvailable--;
                        player.drinksSold++;

                        player.wallet.totalProfit += player.recipe.price;
                    }
                    //{
                    //    Console.WriteLine("Not enough cups...Run out of cups!!!");
                    //}
                }
                else
                {
                    Console.WriteLine("Sold out!");
                }
            }
        }

        public void DisplayProfitLoss()
        {
            Console.WriteLine($"\nDay {currentDay} is over! You sold {player.drinksSold} cups, which brought in ${player.drinksSold * player.recipe.price}");
        }

        public void GameSimulation()
        {
            while (currentDay < 8)
            {
                Console.WriteLine($"\nDay {currentDay} begins!");

                player.DisplayInvetory();
                store.SellItems(player);
                player.DisplayInvetory();

                player.recipe.DisplayRecipe();
                player.recipe.ChangeRecipe();

                days[currentDay].weather.DisplayTemperature();

                int amountOfPitchers = UserInterface.GetNumberOfPitchers();

                player.MakeAPitcher(amountOfPitchers);
                int tempor = 1;
                GenerateCustomers();

                CustomersPurchase();

                DisplayProfitLoss();
                tempor = 0;
                player.drinksAvailable = 0;
                currentDay++;
            }
        }

        public void GameResuts()
        {
            Console.WriteLine($"\nThe week is over. Your total profit is {player.wallet.totalProfit}");
        }

        public void RunGame()
        {
            Welcome();
            GameSimulation();
            GameResuts();
        }
    }
}

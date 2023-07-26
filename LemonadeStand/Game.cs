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

        }

        public void DaylyProfitLoss()
        {

        }

        public void GenerateCustomers()
        {
            //
        }
        
        public void GameSimulation()
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

            player.InventoryAfterMakingPitcher(amountOfPitchers);

            int drinksToBuyAvailable = amountOfPitchers * 8;


          
        }

        public void GameRuslts()
        {

        }

        public void RunGame()
        {
            GameSimulation();
        }

    }
}

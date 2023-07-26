using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        int currentDay;

        Player player;
        Store store;
        List<Day> days;
        

        public Game()
        {
            currentDay = 1;
            player = new Player();
            store = new Store();
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

            player.recipe.price = UserInterface.GetNumberOfPitchers();
            
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

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
            player = new Player();
            store = new Store();

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

        }

        public void GameRuslts()
        {

        }

        void RunGame()
        {

        }

    }
}

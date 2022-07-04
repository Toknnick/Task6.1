using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Max", 20, 321, 99);
            player.ShowInfo();
        }
    }

    class Player
    {
        private string _name;
        private int _level;
        private int _points;
        private int _health;
        
        public Player(string name, int level, int points, int health)
        {
            _name = name;
            _level = level;
            _points = points;
            _health = health;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {_name}. Уровень: {_level}. Очки: {_points}. Здоровье: {_health}");
        }
    }
}
 
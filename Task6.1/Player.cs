using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    internal class Player
    {
        public string Name;
        public int Level;
        public int Points;
        public int Health;

        public Player(string name, int level, int points, int health)
        {
            Name = name;
            Level = level;
            Points = points;
            Health = health;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}. Уровень: {Level}. Очки: {Points}. Здоровье: {Health}");
        }
    }
}

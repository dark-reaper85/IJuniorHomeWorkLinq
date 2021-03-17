using System;
using System.Collections.Generic;
using System.Linq;

namespace TopServerPlayers
{
    class TopPlayersOfServer
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
            {
                new Player("Иванов", 23, 2 ),
                new Player("Петров", 35, 4 ),
                new Player("Дикинсон", 78, 12 ),
                new Player("ТумбаЮмба", 15, 1 ),
                new Player("Сталлоне", 67, 11 ),
                new Player("Кант", 122, 25 ),
                new Player("Чикатилло", 48, 35 ),
                new Player("Дрозденко", 52, 85 ),
                new Player("Хуй", 22, 64 ),
                new Player("МакДак", 145, 86 ),
                new Player("Бигль", 12, 36 )
            };

            var top3ByLevel = players
                .OrderByDescending(player => player.Level)
                .Take(3);

            foreach (var player in top3ByLevel)
            {
                player.ShowInfo();
            }

            Console.WriteLine();

            var top3ByPower = players
                .OrderByDescending(player => player.Power)
                .Take(3);
                

            foreach (var player in top3ByPower)
            {
                player.ShowInfo();
            }
        }
    }

    class Player 
    {
        public string FullName { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Player(string fullName, int level, int power) 
        {
            FullName = fullName;
            Level = level;
            Power = power;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Игрок: {FullName}. Уровень: {Level}. Сила: {Power}");
        }
    }
}

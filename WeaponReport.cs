using System;
using System.Collections.Generic;
using System.Linq;

namespace WeaponReportLinq
{
    class WeaponReport
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>
            {
                new Soldier("Иванов", "Автомат","рядовой", 2 ),
                new Soldier("Петров", "пистолет","Майор", 4 ),
                new Soldier("Дикинсон", "Автомат","рядовой", 12 ),
                new Soldier("ТумбаЮмба", "пистолет", "рядовой",1 ),
                new Soldier("Сталлоне", "пулемет","Майор", 11 ),
                new Soldier("Кант", "Автомат", "рядовой", 16 ),
                new Soldier("Чикатилло", "пистолет","капитан", 35 ),
                new Soldier("Дрозденко", "Автомат","рядовой", 85 ),
                new Soldier("Хуй", "пулемет","Майор", 64 ),
                new Soldier("МакДак", "пистолет","рядовой", 86 ),
                new Soldier("Бигль", "Автомат","Прапор", 36 )
            };

            var report = soldiers.Select(soldier => new
            {
                Name = soldier.Name,
                Rank = soldier.Rank
            });

            foreach (var soldier in report)
            {
                Console.WriteLine($"Имя: {soldier.Name}. Звание: {soldier.Rank}");
            }

        }
    }

    class Soldier 
    {
        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string Rank { get; private set; }
        public int ServiceTerm { get; private set; }

        public Soldier(string name, string weapon, string rank, int serviceTerm) 
        {
            Name = name;
            Weapon = weapon;
            Rank = rank;
            ServiceTerm = serviceTerm;
        }
    }
}

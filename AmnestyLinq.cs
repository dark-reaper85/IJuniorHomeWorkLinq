using System;
using System.Collections.Generic;
using System.Linq;

namespace Amnesty
{
    class AmnestyLinq
    {
        static void Main(string[] args)
        {
            List<Criminal> criminals = new List<Criminal>
            {
                new Criminal("Иванов","Антиправительственное" ),
                new Criminal("Петров","Убийство" ),
                new Criminal("Дикинсон","Воровство" ),
                new Criminal("ТумбаЮмба","Антиправительственное" ),
                new Criminal("Сталлоне","Убийство" ),
                new Criminal("Кант","Антиправительственное" ),
                new Criminal("Чикатилло","Воровство" ),
                new Criminal("Дрозденко","Антиправительственное" ),
                new Criminal("Хуй","Антиправительственное" ),
                new Criminal("МакДак","Убийство" ),
                new Criminal("Бигль","Воровство" )
            };

            foreach (var criminal in criminals)
            {
                Console.WriteLine($"Преступник: {criminal.FullName}. Преступление: {criminal.Crime}.");
            }
            Console.WriteLine();

            var criminalsAfterAmnesty = criminals.Where(criminal => criminal.Crime != "Антиправительственное").ToList();

            criminals = criminalsAfterAmnesty;

            foreach (var criminal in criminals)
            {
                Console.WriteLine($"Преступник: {criminal.FullName}. Преступление: {criminal.Crime}.");
            }
        }
    }

    class Criminal
    {
        public string FullName { get; private set; }
        public string Crime { get; private set; }

        public Criminal(string fullName, string crime)
        {
            FullName = fullName;
            Crime = crime;
        }
    }
}

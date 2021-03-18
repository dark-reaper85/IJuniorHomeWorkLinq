using System;
using System.Collections.Generic;
using System.Linq;

namespace IJuniorHomeWorkLINQ
{
    class CriminalsList
    {
        static void Main(string[] args)
        {
            List<Criminal> criminals = new List<Criminal>
            {
                new Criminal("Иванов",false, 185 , 80 ,"Русский" ),
                new Criminal("Петров",false, 170 , 65 ,"Русский" ),
                new Criminal("Дикинсон",true, 185 , 80 ,"Американец" ),
                new Criminal("ТумбаЮмба",false, 160 , 80 ,"Негр" ),
                new Criminal("Сталлоне",false, 155 , 80 ,"Итальянец" ),
                new Criminal("Кант",true, 185 , 80 ,"Немец" ),
                new Criminal("Чикатилло",false, 205 , 80 ,"Русский" ),
                new Criminal("Дрозденко",true, 172 , 80 ,"Украинец" ),
                new Criminal("Хуй",false, 167 , 80 ,"Кореец" ),
                new Criminal("МакДак",false, 50 , 35 ,"утка" ),
                new Criminal("Бигль",true, 60 , 65 ,"Пес" )
            };

            int minHeight = 180;
            int maxHeight = 200;
            int minWeight = 70;
            int maxWeight = 100;
            string nationality = "Русский";

            var wantedCriminals = criminals
                .Where(criminal => 
                criminal.EnclosedInGuard == false
                && criminal.Height >= minHeight 
                && criminal.Height <= maxHeight 
                && criminal.Weight >= minWeight 
                && criminal.Weight <= maxWeight 
                && criminal.Nationality == nationality);

            foreach (var criminal in wantedCriminals)
            {
                Console.WriteLine($"{criminal.FullName}. Рост: {criminal.Height}. Вес: {criminal.Weight}. Национальность: {criminal.Nationality}");
            }

            Console.ReadKey();
        }
    }

    class Criminal 
    {
        public string FullName { get; private set; }
        public bool EnclosedInGuard { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public string Nationality { get; private set; }

        public Criminal(string fullName, bool enclosedInGuard, int height, int weight, string nationality) 
        {
            FullName = fullName;
            EnclosedInGuard = enclosedInGuard;
            Height = height;
            Weight = weight;
            Nationality = nationality;
        }
    }
}

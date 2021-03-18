using System;
using System.Collections.Generic;
using System.Linq;

namespace OverdueGoods
{
    class SearchForOverdueGoods
    {
        static void Main(string[] args)
        {
            List<Cannedize> cannedizes = new List<Cannedize>()
            {
                new Cannedize("Говядина", 1985, 7),
                new Cannedize("Свинина", 1975, 5),
                new Cannedize("Конина", 2012, 6),
                new Cannedize("Бобы", 2020, 4),
                new Cannedize("Говядина", 2018, 8),
                new Cannedize("Свинина", 2015, 12),
                new Cannedize("Конина", 2018, 3),
                new Cannedize("Бобы", 2015, 6),
                new Cannedize("Говядина", 2019, 22),
                new Cannedize("Свинина", 2001, 5),
                new Cannedize("Конина", 2003, 4),
                new Cannedize("Бобы", 2014, 3),
            };

            int currentYear = 2019;

            var overdueCannedizes = cannedizes.Where(cannedize => cannedize.ProductionYear + cannedize.ShelfLife < currentYear);

            int overdueValue;
            foreach (var cannedize in overdueCannedizes)
            {
                overdueValue = currentYear - cannedize.ProductionYear - cannedize.ShelfLife;
                Console.WriteLine($"{cannedize.Name}. Год выпуска: {cannedize.ProductionYear}. Просрочена на {overdueValue} лет");
            }
        }
    }

    class Cannedize 
    {
        public string Name { get; private set; }
        public int ProductionYear { get; private set; }
        public int ShelfLife { get; private set; }

        public Cannedize(string name, int productionYear, int shelfLife) 
        {
            Name = name;
            ProductionYear = productionYear;
            ShelfLife = shelfLife;
        }
    }
}

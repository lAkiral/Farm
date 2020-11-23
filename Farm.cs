using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Farm
    {
        public string Name;
        public int Square;
        public List<string> ListOfGardenBed = new List<string>();
        public List<string> ListOfBuildings = new List<string>();

        public void report()
        {
            Console.WriteLine($"Название фермы: {Name}, площадь фермы: {Square}");
            Console.Write("Список грядок: ");
            foreach (string Garden in ListOfGardenBed)
            {
                Console.Write(Garden);Console.Write("  ");
            }
            Console.WriteLine();
            Console.Write("Список стоений: ");
            foreach (string Build in ListOfBuildings)
            {
                Console.Write(Build, "  "); Console.Write("  ");
            }
        }
    }
}

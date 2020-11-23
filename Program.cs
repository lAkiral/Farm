using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm Farm1 = new Farm();
            Farm1.Name = "Майнкрафт";
            Farm1.Square = 100;
            Farm1.ListOfBuildings.AddRange(new string[] { "Курятник","Свинарник","Коровник" });
            Farm1.ListOfGardenBed.AddRange(new string[] { "Марковка", "Картошка", "Лук" });
            Farm1.report();
        }
    }
}

using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int numCeleb = int.Parse(Console.ReadLine());
            int gamesSundayHomeT = int.Parse(Console.ReadLine());

            double gameSfWeekend = ((48-gamesSundayHomeT) * 0.75);

            double playSfCelebr = numCeleb * 0.66666667;
            double totalGmes = gameSfWeekend + gamesSundayHomeT + playSfCelebr;

            if (word == "leap")
            {

                double additional = totalGmes * 0.15;
                double total = totalGmes + additional;
                Console.WriteLine($"{Math.Floor(total)}");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(totalGmes)}");

            }
        }
    }
}

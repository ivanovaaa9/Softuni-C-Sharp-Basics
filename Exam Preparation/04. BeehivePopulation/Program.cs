using System;

namespace _04._BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppopulationFirst = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int beesNew = 0;
            int beesDied = 0;
            int beesMig = 0;
            for (int i = 1; i <= years; i++)
            {
                if (i%5==0)
                {

                    beesNew = (ppopulationFirst / 10) * 2;
                    ppopulationFirst += beesNew;
                    
                    beesMig = (ppopulationFirst / 50) * 5;
                    ppopulationFirst -= beesMig;
                    beesDied = ppopulationFirst / 20 * 2;
                    ppopulationFirst -= beesDied;

                }
                else if (ppopulationFirst >= 10)
                {
                    beesNew = (ppopulationFirst / 10) * 2;
                    ppopulationFirst += beesNew;
                    beesDied = ppopulationFirst / 20 * 2;
                    ppopulationFirst -= beesDied;
                }

            }
            Console.WriteLine($"Beehive population: {ppopulationFirst}");
        }
    }
}


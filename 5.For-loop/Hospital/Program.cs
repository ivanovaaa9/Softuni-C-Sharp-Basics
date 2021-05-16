using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int medics = 7;
            int trated = 0;
            int notTreated = 0;
            for(int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && notTreated > trated)
                {
                    medics++;
                }
                if (patients <= medics)
                {
                    trated += patients;
                }
                else
                {
                    notTreated += patients - medics;
                    trated += medics;
                   
                }
            }
            Console.WriteLine("Treated patients: " + trated + ".") ;
            Console.WriteLine("Untreated patients: " + notTreated + ".");
        }
    }
}

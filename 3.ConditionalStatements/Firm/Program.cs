using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());

            double workHours = (days - (days * 0.1));
            double jj = workHours* 8; //21.6
            double hh = 2 * days;  //6
            double AdditionWork = numWorkers * hh; //6
            double totalHours = Math.Floor(jj + AdditionWork);
            if (hours <= totalHours)
            {
                double diff = totalHours - hours;

                Console.WriteLine($" Yes!{Math.Floor(diff)} hours left.");
            }
            else
            {
                double diff = hours - totalHours;
                Console.WriteLine($"Not enough time!{Math.Ceiling(diff)} hours needed." );
            }
                    
            
        }
    }
}

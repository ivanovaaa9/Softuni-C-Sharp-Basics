using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeSekFor1M = double.Parse(Console.ReadLine());

            double clim = meters * timeSekFor1M;
            double sekAdded = (Math.Floor(meters / 50)) * 30;
            double total = clim + sekAdded;
            if (total >= record)
            {
                Console.WriteLine($"No! He was {total-record:f2} seconds slower.");
            }
            else if (total < record)
            {
                Console.WriteLine($" Yes! The new record is {total:f2} seconds.");
            }
            

        }
    }
}

using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDys = int.Parse(Console.ReadLine());
            int freeDaysinMin = freeDys * 127;
            int workDays = 365 - freeDys;
            int MworkDays = workDays * 63;
            int sumTimePlay = MworkDays + freeDaysinMin;

            int DifferenceInMin = Math.Abs(sumTimePlay - 30000);
            int diffInHours = DifferenceInMin / 60;
            double diffMin = DifferenceInMin % 60;
            if (sumTimePlay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diffInHours} hours and {diffMin} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diffInHours} hours and {diffMin} minutes less for play");

            }






        }
    }
}

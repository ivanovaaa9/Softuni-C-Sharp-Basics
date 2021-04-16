using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            //math.floor - delays in every 15 m * пътите в който се забавя
            double swimTime = distance * timePerMeter;
            double delayTime = Math.Floor(distance / 15 ) * 12.5;
            double totalTime = swimTime + delayTime;
            // better record?
            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double needSek = totalTime - record;
                Console.WriteLine($"No, he failed! He was {needSek:f2} seconds slower.");
            }



        }
    }
}

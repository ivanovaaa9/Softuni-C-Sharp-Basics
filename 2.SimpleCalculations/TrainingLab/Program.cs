using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            // METERS TO SANTIMETERS
            double metersH = h * 100 / 120;
            double metersW = (w * 100 - 100) / 70;
            // function for division with "остатък"
            //70 size  ширина
            //120 size  височIна
            double metersF = Math.Truncate(metersW);
            double metersG = Math.Truncate(metersH);
            Console.WriteLine((metersF * metersG) - 3);



        }
    }
}

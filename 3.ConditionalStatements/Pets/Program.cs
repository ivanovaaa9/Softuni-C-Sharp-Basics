using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dayFDog = double.Parse(Console.ReadLine());
            double dayFCAt = double.Parse(Console.ReadLine());
            double dayFturt = double.Parse(Console.ReadLine());

            double convert = dayFturt / 1000;

            double dog = days * dayFDog;
            double cat = days * dayFCAt;
            double turtle = days * convert;

            double sumF = dog + cat + turtle;
            if(sumF <= foodKg)
            {
                double sum = foodKg - sumF;
                Console.WriteLine($"{Math.Floor(sum)} kilos of food left.");
            }
            else
            {
                double sum = sumF - foodKg;
                Console.WriteLine($"{Math.Ceiling(sum)} more kilos of food are needed.");
            }



        }
    }
}

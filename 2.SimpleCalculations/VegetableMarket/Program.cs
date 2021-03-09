using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double row1 = double.Parse(Console.ReadLine());
            double row2 = double.Parse(Console.ReadLine());
            int row3 = int.Parse(Console.ReadLine());
            int row4 = int.Parse(Console.ReadLine());

            double priceVeggie = row1 * row3;
            double priceFruits = row2 * row4;
            double sum = (priceFruits + priceVeggie) / 1.94;

            Console.WriteLine($"{sum:f2}");




        }
    }
}

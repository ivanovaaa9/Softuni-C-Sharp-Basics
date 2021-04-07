using System;

namespace _07.AlkoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
          
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double wiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double sumRakia = rakiaPrice * rakiaQuantity;

            double beerPrice = rakiaPrice - 0.8 * rakiaPrice;
            double beerSum = beerQuantity * beerPrice;

            double winePrice = rakiaPrice - 0.4 * rakiaPrice;
            double wineSum = winePrice * wineQuantity;
            double wiskeySum = wiskeyPrice * wiskeyQuantity;

            double totalSum = sumRakia + beerSum + wineSum + wiskeySum;
            Console.WriteLine($"{totalSum:F2}");





        }
    }
}

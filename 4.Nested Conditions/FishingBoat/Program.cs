using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double price = 0;
            

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                
                case "Winter":
                    price = 2600;
                    break;
            }
            if(num <= 6)
            {
                price = price * 0.90;
            }else if(num >= 7 && num <= 11)
            {
                price = price * 0.85;
            }else if(num >= 12)
            {
                price = price * 0.75;
            }
            if(num % 2 ==0 && season != "Autumn")
            {
                price = price * 0.95;
            }
            double totalSum = price;

            if (buget >= totalSum)
            {
                double moneyLeft = buget - totalSum;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }else if(buget < totalSum)
            {
                double moneyNeeded = totalSum - buget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
                
        }
    }
}

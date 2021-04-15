using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int mangolii = int.Parse(Console.ReadLine());
            int zu = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double sum = mangolii * 3.25 + zu * 4 + roses * 3.5 + cactus * 8;
            double win = sum - sum * 0.05;
            if( price > win)
            {
                double diff = price - win;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(diff)} leva." );
            }
            else
            {
                double diff = win - price;
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            }
        }
    }
}

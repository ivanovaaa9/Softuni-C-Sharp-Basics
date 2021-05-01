using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total = puzzle * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            int numOfToys = puzzle + dolls + bears + minions + trucks;

            if (numOfToys >= 50)
            {
                total = total - 0.25 * total;
                //or total -= total * 0.25;
                //total = total * 0.75;
            }

            total = total * 0.9; 
            //10 procents disc.

            if(total >= holidayPrice)
            {
                Console.WriteLine($"Yes! {(total-holidayPrice):f2} lv left.");

            }
            else
            {
                Console.WriteLine($"Not enough money! {(holidayPrice-total):f2} lv needed.");
            }

        }
    }
}

using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            int num = int.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")
            {
                if(num >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                    
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}

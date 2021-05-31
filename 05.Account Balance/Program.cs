using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int transaction = int.Parse(Console.ReadLine());
            double bankA = 0;
            for(int i = 0; i < transaction; i++)
            {
                double money = double.Parse(Console.ReadLine());
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                        break;
                }
                bankA += money;
                Console.WriteLine($"Increase: {money:f2}");
            }
            Console.WriteLine($"Total: {bankA:f2}");
        }
    }
}

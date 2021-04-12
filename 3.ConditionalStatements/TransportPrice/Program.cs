using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numKm = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();
         
            if (word == "day")
            {
                if (numKm >= 100)
                {
                    double price = numKm * 0.06;
                    Console.WriteLine($"{price:f2}");
                }
                else if (numKm >= 20)
                {
                    double price = numKm * 0.09;
                    Console.WriteLine($"{price:f2}");
                }
                 
                else
                {
                    double price = 0.70 + numKm * 0.79;
                    Console.WriteLine($"{price:f2}");
                }
            }
            else if (word == "night")
            {
                if (numKm >= 100)
                {
                    double price = numKm * 0.06;
                    Console.WriteLine($"{price:f2}");
                }
                
                else if (numKm >= 20)
                {
                    double price = numKm * 0.09;
                    Console.WriteLine($"{price:f2}");
                }
                else 
                {
                    double price = 0.70 + (numKm * 0.90);
                    Console.WriteLine($"{price:f2}");
                }

            }

        }
    }
}

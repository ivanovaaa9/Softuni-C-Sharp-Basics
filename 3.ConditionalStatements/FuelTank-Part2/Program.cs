using System;

namespace _08.FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            if (fuel == "Diesel" && card == "Yes" && num < 20)
            {
                double sum = num * 2.21;
                Console.WriteLine($"{sum:f2} lv.");

            }
            else if (fuel == "Diesel" && card == "No" && num < 20)
            {
                double sum = num * 2.33;
                Console.WriteLine($"{sum:f2} lv.");
            }
            else if (fuel == "Diesel" && card == "Yes" && num >= 20 || num <= 25)
            {
                double sum1 = num * 2.21;
                double sum = sum1 - sum1 * 0.08;
                Console.WriteLine($"{sum:f2} lv.");
            }
            else if (fuel == "Diesel" && card == "No" && num >= 20 || num <= 25)
            {
                double sum1 = num * 2.33;
                double sum = sum1 - sum1 * 0.08;
                Console.WriteLine($"{sum:f2} lv.");
            }
            else if (fuel == "Diesel" && card == "Yes" && num > 25)
            {
                double sum1 = num * 2.21;
                double sum = sum1 - sum1 * 0.1;
                Console.WriteLine($"{sum:f2} lv.");
            }
            else if (fuel == "Diesel" && card == "No" && num > 25)
            {
                double sum1 = num * 2.33;
                double sum = sum1 - sum1 * 0.1;
                Console.WriteLine($"{sum:f2} lv.");
            }
            else if (fuel == "Gas")
            {
                if (card == "Yes" && num < 20)
                {
                    double sum = num * 0.85;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "No" && num < 20)
                {
                    double sum = num * 0.93;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "Yes" && num >= 20 || num <= 25)
                {
                    double sum1 = num * 0.85;
                    double sum = sum1 - sum1 * 0.08;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "No" && num >= 20 || num <= 25)
                {
                    double sum1 = num * 0.93;
                    double sum = sum1 - sum1 * 0.08;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "Yes" && num > 25)
                {
                    double sum1 = num * 0.85;
                    double sum = sum1 - sum1 * 0.1;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "No" && num > 25)
                {
                    double sum1 = num * 0.93;
                    double sum = sum1 - sum1 * 0.1;
                    Console.WriteLine($"{sum:f2} lv.");
                }
            }
            else if (fuel == "Gasoline")
            {
                if (card == "Yes" && num < 20)
                {
                    double sum = num * 2.04;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "No" && num < 20)
                {
                    double sum = num * 2.22;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "Yes" && num >= 20 || num <= 25)
                {
                    double sum1 = num * 2.04;
                    double sum = sum1 - sum1 * 0.92;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "No" && num >= 20 || num <= 25)
                {
                    double sum1 = num * 2.22;
                    double sum = sum1 % 8;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "Yes" && num > 25)
                {
                    double sum1 = num * 2.04;
                    double sum = sum1 - sum1 * 0.1;
                    Console.WriteLine($"{sum:f2} lv.");
                }
                else if (card == "No" && num > 25)
                {
                    double sum1 = num * 2.22;
                    double sum = sum1 - sum1 * 0.1;
                    Console.WriteLine($"{sum:f2} lv.");
                }

                //70/100 - mistake in calculating gasoline , 25, no.

            }
        }
    }
}
    

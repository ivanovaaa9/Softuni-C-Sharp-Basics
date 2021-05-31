using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            double sum = 0;
            int num1 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num1; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                num += num2;
                sum = num / num1;

            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}

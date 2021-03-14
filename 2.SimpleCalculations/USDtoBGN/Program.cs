using System;

namespace _01.UDStoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double bgn = dollars * 1.79549;

            Console.WriteLine($"{bgn:F2}");
        }
    }
}

using System;

namespace _03.CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double fahr = celsius * 1.8 + 32;

            Console.WriteLine($"{fahr:f2}");


  
        }
    }
}

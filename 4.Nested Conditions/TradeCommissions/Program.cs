using System;

namespace _09.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double Volumesales = double.Parse(Console.ReadLine());

            double percentage = 0.0;
            if (Volumesales >= 0 && Volumesales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.05;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Varna":
                        percentage = 0.045;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Plovdiv":
                        percentage = 0.055;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                }
            }
           else if (Volumesales >500 && Volumesales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.07;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Varna":
                        percentage = 0.075;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Plovdiv":
                        percentage = 0.08;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
           else if (Volumesales > 1000 && Volumesales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.08;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Varna":
                        percentage = 0.1;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Plovdiv":
                        percentage = 0.12;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
           else if ( Volumesales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.12;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Varna":
                        percentage = 0.13;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    case "Plovdiv":
                        percentage = 0.145;
                        Console.WriteLine($"{(Volumesales * percentage):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}

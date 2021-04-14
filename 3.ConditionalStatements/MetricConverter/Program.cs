using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string valueIn = Console.ReadLine();
            string valueOut = Console.ReadLine();

           if(valueIn == "mm" && valueOut =="m")
            {
                double mm = num / 1000;
                Console.WriteLine($"{mm:f3}");
            }
           else if (valueIn == "m" && valueOut == "mm")
            {
                double m = num * 1000;
                Console.WriteLine($"{m:f3}");
            }
            else if (valueIn == "m" && valueOut == "cm")
            {
                double m = num * 100;
                Console.WriteLine($"{m:f3}");
            }
            else if (valueIn == "cm" && valueOut == "m")
            {
                double m = num / 100;
                Console.WriteLine($"{m:f3}");
            }
            else if (valueIn == "cm" && valueOut == "mm")
            {
                double m = num * 10;
                Console.WriteLine($"{m:f3}");
            }
            else if (valueIn == "mm" && valueOut == "cm")
            {
                double m = num / 10;
                Console.WriteLine($"{m:f3}");
            }

        }
    }
}

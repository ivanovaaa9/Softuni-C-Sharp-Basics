using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string seasion = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double price = 0.0;

            switch (seasion)
            {
                case "Spring":                 
                case "Autumn":
                    if(km <= 5000)
                    {
                        price = 0.75 * km ;
                    }else if(km > 5000 && km <= 10000)
                    {
                        price = 0.95 * km;
                    }else if (km > 10000 && km <= 20000)
                    {
                        price = 1.45 * km;
                    }
                    break;
                case "Summer":
                    if (km <= 5000)
                    {
                        price = 0.90 * km;
                    }
                    else if (km > 5000 && km <= 10000)
                    {
                        price = 1.10 * km;
                    }
                    else if (km > 10000 && km <= 20000)
                    {
                        price = 1.45 * km;
                    }
                    break;
                case "Winter":
                    if (km <= 5000)
                    {
                        price = 1.05 * km;
                    }
                    else if (km > 5000 && km <= 10000)
                    {
                        price = 1.25 * km;
                    }
                    else if (km > 10000 && km <= 20000)
                    {
                        price = 1.45 * km;
                    }
                    break;
            }
            double neew = price * 4;
            double lasts = neew - (0.10 * neew);
            Console.WriteLine($"{lasts:f2}");
            
        }
    }
}

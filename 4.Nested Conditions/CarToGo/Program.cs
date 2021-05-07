using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
                       
            string cars = "";
            string classs = "";
            double price = 0.0;
            if (budget <= 100)
            {
                classs = "Economy class";
                switch (season)
                {
                    case "Summer":
                        cars = "Cabrio";
                        price = budget * 0.35;
                        break;
                    case "Winter":
                        cars = "Jeep";
                        price = budget * 0.65;
                        break;
                }
            }
            if (budget > 100 && budget <=500 )
            {
                classs = "Compact class";
                switch (season)
                {
                    case "Summer":
                        cars = "Cabrio";
                        price = budget * 0.45;
                        break;
                    case "Winter":
                        cars = "Jeep";
                        price = budget * 0.80;
                        break;
                }
            }
            if (budget > 500)
            {
                classs = "Luxury class";
                switch (season)
                {
                    case "Summer":
                    case "Winter":                                                
                       cars = "Jeep";
                        price = budget * 0.90;
                        break;
                }
            }
            Console.WriteLine(classs);
            Console.WriteLine($"{cars} - {price:f2}");


        }
    }
}

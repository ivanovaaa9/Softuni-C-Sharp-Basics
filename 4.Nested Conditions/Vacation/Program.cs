﻿using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string location = "";
            double price = 0.0;
            if (budget <= 1000)
            {
                place = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.45;
                        break;
                }
            }
            if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.60;
                        break;
                }
            }
            if (budget > 3000)
            {
                place = "Hotel";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.90;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.90;
                        break;
                }
            }
            
            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}

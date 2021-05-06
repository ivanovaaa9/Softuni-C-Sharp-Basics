using System;

namespace _03.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            string outfit;
            string shoes;

            switch (text)
            {
                case "Morning":
                    if (degree >= 10 && degree <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if(degree >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                case "Afternoon":
                    if (degree >= 10 && degree <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degree >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                case "Evening":
                    if (degree >= 10 && degree <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degree >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                    

            }
        }
    }
}

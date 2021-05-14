using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();
            double price = 0;
            double discounts = 0;

            int nights = days - 1;
            switch (room) {
                case "room for one person":
                    price = 18;
                    break;
                case "apartment":
                    price = 25;
                    if (days < 10)
                    {
                        discounts = 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discounts = 0.35;
                    }
                    else if (days > 15)
                    {
                        discounts = 0.50;
                    }
                    break;
                case "president apartment":
                    price = 35;
                    if (days < 10)
                    {
                        discounts = 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discounts = 0.15;
                    }
                    else if (days > 15)
                    {
                        discounts = 0.20;
                    }

                    break;
            }
            double totaPrice = nights * price;
            totaPrice -= totaPrice * discounts;

            if(review == "positive")
            {
                totaPrice += totaPrice * 0.25;
            }
            else
            {
                totaPrice -= totaPrice * 0.10;
            }
            Console.WriteLine($"{totaPrice:f2}");


        }
    }
}


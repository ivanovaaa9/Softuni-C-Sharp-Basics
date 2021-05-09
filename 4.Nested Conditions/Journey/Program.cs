using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string room = "";
            switch (season)
            {
                case "summer":
                    
                    if(budget <= 100)
                    {
                        room = "Camp";
                        destination = "Bulgaria";
                        budget = budget * 0.30;

                    }else if(budget <= 1000)
                    {
                        room = "Camp";
                        destination = "Balkans";
                        budget = budget * 0.40;
                    }else if(budget > 1000)
                    {
                        room = "Hotel";
                        destination = "Europe";
                        budget = budget * 0.90;
                    }
                    break;
                case "winter":
                    room = "Hotel";
                    if (budget <= 100)
                    {
                        room = "Hotel";
                        destination = "Bulgaria";
                        budget = budget * 0.70;

                    }
                    else if (budget <= 1000)
                    {
                        room = "Hotel";
                        destination = "Balkans";
                        budget = budget * 0.80;
                    }
                    else if (budget > 1000)
                    {
                        room = "Hotel";
                        destination = "Europe";
                        budget = budget * 0.90;
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{room} - {budget:f2}");
                

        }
    }
}

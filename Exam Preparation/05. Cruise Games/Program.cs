using System;

namespace _05._Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());
            int vGames = 0;
            double vPoints = 0;
            int tGames = 0;
            double tPoints = 0;
            int bGames = 0;
            double bPoints = 0;
            for (int i = 1; i <= playedGames; i++)
            {
                string nameGame = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                switch (nameGame)
                {
                    case "volleyball":
                        vGames++;
                        vPoints += points + points * 0.07;
                        break;
                    case "tennis":
                        tGames++;
                        tPoints += points + points * 0.05;
                        break;
                    case "badminton":
                        bGames++;
                        bPoints += points + points * 0.02;
                        break;
                }
            }
                double average1 = Math.Floor(vPoints / vGames);
                double average2 = Math.Floor(tPoints / tGames);
                double average3 = Math.Floor(bPoints / bGames);
                double totall = bPoints + vPoints + tPoints;
                if (average1 >= 75&& average2 >= 75 && average3 >= 75)
                {
                    Console.WriteLine($"Congratulations, {name}! You won the cruise games with {Math.Floor(totall)} points.");
                }
                else
                {
                    Console.WriteLine($"Sorry, {name}, you lost. Your points are only {Math.Floor(totall)}.");
                }
            }
        }
    }


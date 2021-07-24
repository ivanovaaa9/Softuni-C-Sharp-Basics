using System;

namespace _04._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalPoints = int.Parse(Console.ReadLine());
           
            int trials = 0;
            while (true)
            {
                 string sector = Console.ReadLine();
                trials++;

                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {trials} moves!");

                    break;
                }

                int numPoints = int.Parse(Console.ReadLine());
                switch (sector)
                {
                    case "number section":

                        totalPoints = totalPoints - numPoints;
                        break;
                    case "double ring":
                        totalPoints = totalPoints - numPoints * 2;
                        break;
                    case "triple ring":
                        totalPoints = totalPoints - numPoints * 3;
                        break;
                }

                if (totalPoints == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {trials} moves!");
                    break;
                }
                else if (totalPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(totalPoints)}.");
                    break;
                }

            }

        }



    }
}


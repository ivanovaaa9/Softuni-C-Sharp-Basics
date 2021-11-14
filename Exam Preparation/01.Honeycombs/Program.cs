using System;

namespace _01.Honeycombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int flowers = int.Parse(Console.ReadLine());

            double gramsHoney = bees * flowers * 0.21;
            double numP = Math.Floor(gramsHoney / 100);
            double h = numP * 100;
            double left = gramsHoney - h;

            Console.WriteLine($"{numP} honeycombs filled.");
            Console.WriteLine($"{left:f2} grams of honey left.");





        }
    }
}

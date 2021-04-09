using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            //double water = p1 * h + p2 * h;

        
            

            double firstPipe = p1 * h;
            double secodPipe = p2 * h;
            double sum = firstPipe + secodPipe;
            

                if (sum <= v)
                {
                    double full = (sum / v) * 100;
                    double firtsP = (firstPipe / sum) * 100;
                    double secondP = (secodPipe / sum) * 100;
                    Console.WriteLine($"The pool is {full:f2}% full. Pipe 1: {firtsP:f2}%. Pipe 2: {secondP:f2}%.");

                }
                else if (sum > v)
                {
                    double sum1 = sum - v;
                    Console.WriteLine($"For {h:f2} hours the pool overflows with {sum1:f2} liters.");
                }



            
        }
    }
}

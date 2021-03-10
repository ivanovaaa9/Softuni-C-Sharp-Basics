using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double sideS = x * y;
            double window = 1.5 * 1.5;
            double bothSides = 2 * sideS - 2 * window;
            double backSide = x * x;
            double entrance = 1.2 * 2;
            double SUM = 2 * backSide - entrance;

            double commonS = bothSides + SUM;
            double greenPaint = commonS / 3.4;

            double bothRectTop = 2 * (x * y);
            double rectangle = 2 * (x * h / 2);
            double commonSs = bothRectTop + rectangle;
            double redPaint = commonSs / 4.3;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");






        }
    }
}

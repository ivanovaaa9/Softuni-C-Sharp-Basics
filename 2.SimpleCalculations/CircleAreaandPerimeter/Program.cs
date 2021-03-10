using System;

namespace _08.CircleAreaandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * (r*r);
            double p = 2 * r * Math.PI;
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{p:f2}");



        }
    }
}

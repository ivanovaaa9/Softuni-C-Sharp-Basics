﻿using System;

namespace _04.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double transform = inch * 2.54;
            Console.WriteLine(transform);
        }
    }
}

﻿using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int difficulty = int.Parse(Console.ReadLine());
            int cir = int.Parse(Console.ReadLine());

            int numPages = int.Parse(Console.ReadLine());

            if (difficulty >= 80 && cir >= 80 && numPages >= 8)
            {
                Console.WriteLine("Legacy");
            }
            else if (difficulty >= 80 && cir <= 10 && numPages > 0)
            {
                Console.WriteLine("Master");

            }
            else if (difficulty >0 && cir >= 50 && numPages >=2 )
            {
                Console.WriteLine("Hard");

            }
            
            else if (difficulty <= 30 && cir > 0 && numPages<=1)
            {
                Console.WriteLine("Easy");

            }
            else if (difficulty <= 10 && cir> 0 && numPages > 0)
            {
                Console.WriteLine("Elementary");

            }
            else if (difficulty > 0 && cir > 0 && numPages > 0)
            {
                Console.WriteLine("Regular");

            }//90/100

        }
    }
}

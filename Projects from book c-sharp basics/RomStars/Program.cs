﻿using System;

namespace RomStares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <n- row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();

                //...down side
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.Write("*");
                for (int col = 1; col < n - row; col++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}

﻿using System;

namespace _08.Numbersequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

             for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if(currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                if (currentNum<minNum)
                {
                    minNum = currentNum;                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");




        }
    }
}

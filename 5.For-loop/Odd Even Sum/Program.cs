﻿using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            
            for(int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    evenSum += currentNum;                   
                }
                else
                {
                    oddSum += currentNum;
                }
               
            }
            if (evenSum == oddSum)
            {

                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);

            }
        }
    }
}

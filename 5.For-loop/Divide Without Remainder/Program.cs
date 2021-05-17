using System;
using System.Text.RegularExpressions;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if(value % 2 == 0)
                {
                    group1 += 1; // увеличаваме стойността на променливата с едно, всеки ът когато условието се изпълнява , count of the numbers in the first group - add 1 every time
                }
                if(value%3 == 0)
                {
                    // интересува ни колко числа влизат в група , не тяхната стойнот
                    group2 += 1;//group2++
                }
                if (value % 4 == 0)
                {
                    group3++;
                    //group = group + 1 - събира текущата стойност на груп е 1
                }
            }//% numbers in the 3 groups
            double percent1 = (group1*1.0) / n * 100;
            double percent2 = (group2*1.0) / n * 100;
            double percent3 = (group3*1.0) / n * 100;
            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");






        }
    }
}

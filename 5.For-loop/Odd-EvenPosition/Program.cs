using System;

namespace _03._Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double even = 0;
            double odd = 0;
            double maxOdd = -1000000000.0;
            double maxEven = -1000000000.0;
            double minEven = 1000000000.0;
            double minOdd = 1000000000.0;
            for (int numPosition = 1; numPosition <= n; numPosition++)
            {
                double value = double.Parse(Console.ReadLine());
                if (numPosition % 2 == 0)
                {    even += value;
                    //check max
                    if(value > maxEven)//num > from max - max get this number because it larger
                    {
                        maxEven = value;
                    }
                    //check min
                    if(value <= minEven)
                    {
                        minEven = value;
                    }
                }            
                else
                {
                    odd += value;
                    if (value > maxOdd)
                    {
                        maxOdd = value;
                    }
                    if(value <= minOdd)
                    {
                        minOdd = value;
                    }
                }

            }
            Console.WriteLine($"OddSum={odd:f2},");
            if (minOdd == 1000000000.0)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
            }
            if (maxOdd == -1000000000.0)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }
            Console.WriteLine($"EvenSum={even:f2},");
            if (minEven == 1000000000.0)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:f2},");
            }
            if (maxEven == -1000000000.0)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
        }
    }
}

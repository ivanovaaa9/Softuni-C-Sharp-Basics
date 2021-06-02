using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxN = int.MinValue;
            int count = 0;
            while (count != n)
            {
                int newN = int.Parse(Console.ReadLine());
                if (newN > maxN)
                {
                    maxN = newN;

                }
                count++;

            }
            Console.WriteLine(maxN);

        }
    }
}

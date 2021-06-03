using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int count = 0;
            while(count != n)
            {
                int newN = int.Parse(Console.ReadLine());
                if(newN < min)
                {
                    min = newN;
                }
                count++;
            }
            Console.WriteLine(min);
        }
    }
}

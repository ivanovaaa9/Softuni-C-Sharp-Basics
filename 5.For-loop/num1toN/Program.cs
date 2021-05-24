using System;

namespace num1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           /* 1 to n
            * for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }*/
            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

    }
}

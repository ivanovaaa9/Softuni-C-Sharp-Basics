using System;
using System.Diagnostics.Tracing;

namespace Num1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <=100; i++)
            {
                Console.WriteLine(i);
            }

             /*   for(int counter = 0; counter < 5; counter += 1)
            {
                Console.WriteLine("HEY");
                Console.WriteLine("Smileee");
            }*/
        }
    }
}

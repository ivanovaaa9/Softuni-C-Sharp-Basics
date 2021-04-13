using System;

namespace _02.GretaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   double result = double.Parse(Console.ReadLine());
               if (result >= 5.50)
               {
                   Console.WriteLine("Excellent!");
               }
               */
            int result = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            if (result > num)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(num);
            }

        }
    }
}

using System;

namespace _09.Multiplyby2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   double i;
              // var random = new Random();

               for (i = 1; ;i++) {
                   if (i > 0)
                   {
                       Console.WriteLine("Result: " + i * 2);
                   }
                   else
                   {
                       Console.WriteLine("Negative number!");
                   }*/
            double num = 0;
            double sum = 0;
                while(num >= 0)
            {
                num = double.Parse(Console.ReadLine());
                num++;
                if (num > 0)
                {
                    sum = num * 2 - 2;
                    Console.WriteLine($"Result: {sum:f2}");
                }
            }

            if (num < 0)
            {
                
                Console.WriteLine("Negative number!");
                
            }



        } }
    }


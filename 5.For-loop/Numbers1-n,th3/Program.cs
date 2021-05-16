using System;

namespace _03.Numbers1_n_th3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = int.MinValue;
            Console.WriteLine(num-2);*/
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i+=3)
            {
                Console.WriteLine(i);
            }

            }
        }
    }


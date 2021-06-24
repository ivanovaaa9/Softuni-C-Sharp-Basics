using System;
using System.Globalization;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int floorsNum = int.Parse(Console.ReadLine());
            int Rooms = int.Parse(Console.ReadLine());

            for (int i = floorsNum; i >=1; i--){
                for(int j = 0; j < Rooms; j++)
                {
                    if(floorsNum == i)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                     else {
                        Console.Write($"A{i}{j} ");
                    }
                   

                }
                Console.WriteLine("");

            }
        }
    }
}

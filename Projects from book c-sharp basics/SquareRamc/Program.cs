using System;

namespace SquareRamc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int up = 0; up < n-2; up++)
            {               
                Console.Write(" -");                
            }
            Console.WriteLine(" +");

            for(int i = 0; i < n-2; i++)
            {
                Console.Write("|");
                for(int r = 0; r < n-2; r++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int up = 0; up < n - 2; up++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

        }
    }
}

using System;

namespace CubNbyN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine("*");
                for(int r = 1; r < n; r++)
                {
                    Console.WriteLine(" *");
                }
                Console.WriteLine(); 
            }
        }
    }
}

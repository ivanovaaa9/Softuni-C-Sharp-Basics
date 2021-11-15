using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <=n; i++)
            {
                var stars = new string('*', i);
                var space = new string(' ',n- i);
                Console.Write(space);
                Console.Write(stars);
                Console.Write("|");
                Console.Write(stars);
                Console.WriteLine(space);

            }
        }
    }
}

using System;

namespace NbyNstars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {

                Console.Write(new string('*', num));
            }
        }
    }
}

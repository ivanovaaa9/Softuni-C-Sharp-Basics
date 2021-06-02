using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            double size = width * lenght;
            int pieceTaken = 0;
           
            string com = Console.ReadLine().ToUpper();

            while (com != "STOP")
            {

                pieceTaken = int.Parse(com);
                size -= pieceTaken;

                if (size < 0)
                {

                    Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
                    break;
                }
                com = Console.ReadLine();
            }
                if (com == "STOP")
                {
                   
                    Console.WriteLine($"{size} pieces are left.");
                }
            


        }
    }
}

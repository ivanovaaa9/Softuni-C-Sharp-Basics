using System;

namespace Book.pg97_Repairing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            int sum = n * n;
            int bench = m * o;
            int placeCover = sum - bench;
            double pl = w * l;
            double nes = placeCover / pl;
            double time = nes * 0.2;

            Console.WriteLine(nes);
            Console.WriteLine(time);
           
        }
    }//name change tiles
}

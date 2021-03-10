using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double sk = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double pala = double.Parse(Console.ReadLine());
            double saf = double.Parse(Console.ReadLine());
            int midi = int.Parse(Console.ReadLine());

            double pricePala = sk + sk * 0.60;
            double sumPala = pala * pricePala;
            double priceSaf = caca + caca * 0.80;
            double sumSaf = priceSaf * saf;
            double sumMidi = midi * 7.50;

            double sum = sumPala + sumSaf + sumMidi;

            Console.WriteLine($"{sum:f2}");

           
        }
    }
}

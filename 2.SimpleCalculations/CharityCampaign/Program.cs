using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gof = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesSales = cakes * 45;
            double gofSales = gof * 5.80;
            double pancakesSales = pancakes * 3.20;

            double sum = (cakesSales + gofSales + pancakesSales) * people;
            double Ss = sum * days;
            double final = Ss - (Ss/8);

            Console.WriteLine($"{final:F2}");




        }
    }
}

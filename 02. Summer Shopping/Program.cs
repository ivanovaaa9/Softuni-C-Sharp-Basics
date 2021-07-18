using System;
using System.Runtime.InteropServices.ComTypes;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double priceTower = double.Parse(Console.ReadLine());
            int discountP = int.Parse(Console.ReadLine());

            double umbrela = (2.0 / 3) * priceTower;
            double flipflops = 0.75 * umbrela;
            double bagP = 1.0 / 3 * (priceTower + flipflops);

            double total = priceTower + umbrela + flipflops + bagP;
            total -= (discountP / 100.00) * total;

            if (budget >= total)
            {
                Console.WriteLine($"Annie's sum is {total:f2} lv. She has {budget-total:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {total:f2} lv. She needs {total-budget:f2} lv. more.");
            }



        }
    }
}

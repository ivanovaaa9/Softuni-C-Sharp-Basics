using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());

            double  sumGrapes = x * y;
            double wine =((sumGrapes * 0.4) / 2.5);
            if (wine >= z)
            {
                double he = Math.Ceiling(wine - z);
                double people = Math.Ceiling(he / numWorkers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{he} liters left -> {people} liters per person.");
            
            }
            else if (wine < z)
            {
                double he = (z - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(he));

            }



        }
    }
}

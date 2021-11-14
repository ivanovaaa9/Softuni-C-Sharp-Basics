using System;

namespace _06._HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyWinter = double.Parse(Console.ReadLine());
            string inputOrName = Console.ReadLine();
            double sumHoney = 0;

            while (inputOrName != "Winter has come")
            {

                for (int i = 1; i <= 6; i++)
                {
                    
                        double honeyS = double.Parse(Console.ReadLine());
                        sumHoney += honeyS;

                    
                    
                }


                if (sumHoney < 0)
                {
                    Console.WriteLine($"{inputOrName} was banished for gluttony");

                }
                if (sumHoney >= honeyWinter)
                {
                    Console.WriteLine($"Well done! Honey surplus {sumHoney - honeyWinter:f2}.");

                }
                else if (sumHoney < honeyWinter)
                {
                    Console.WriteLine($"Hard Winter! Honey needed {honeyWinter - sumHoney:f2}.");


                }

            }
        }
    }
}
    


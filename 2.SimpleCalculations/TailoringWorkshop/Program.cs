using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {

            int countTables = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double wideTables = double.Parse(Console.ReadLine());

            double sumP = countTables * (lenghtTable + 2 * 0.30) * (wideTables + 2 * 0.30);
            double sumK = countTables * (lenghtTable / 2) * (lenghtTable / 2);
           
            double dollar = sumP * 7 + sumK * 9;
            double lv = dollar * 1.85;

            Console.WriteLine($"{dollar:F2} USD");
            Console.WriteLine($"{lv:F2} BGN");


        }
    }
}

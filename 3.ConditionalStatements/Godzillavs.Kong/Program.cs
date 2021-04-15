using System;

namespace _06.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numstatists = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double decor = 0.10 * budget;
            //взимаме 10 % от бюджета
            double clothes = numstatists * price;
             if (numstatists > 150)
            {
                clothes = clothes - 0.10 * clothes; // 0.9 * clothes
            }
            double expenses = decor + clothes;
            //enough money
            if (budget >= expenses)
            {
                Console.WriteLine("Action!");
                double leftmoney = budget - expenses;
                Console.WriteLine($"Wingard starts filming with {leftmoney:f2} leva left.");
            }
            else
            //nor enough money
            {
                Console.WriteLine("Not enough money!");
                double needm = expenses - budget;
                Console.WriteLine($"Wingard needs {needm:f2} leva more.");
            }


        }
    }
}

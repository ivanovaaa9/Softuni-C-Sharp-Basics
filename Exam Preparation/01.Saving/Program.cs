using System;

namespace _01.Saving
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double sumNeeded = double.Parse(Console.ReadLine());

            double saved = income - ((income * 0.3) + sumNeeded);
            double savedMoney = saved * months;
            double percentage = (saved / income) * 100;

            Console.WriteLine($"She can save {percentage:f2}%");
            Console.WriteLine($"{savedMoney:f2}");



        }
    }
}

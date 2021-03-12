using System;

namespace DailyEarnings_book
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double DollarLv = double.Parse(Console.ReadLine());

            double SalaryMonth = days * money;
            double yearIncome = SalaryMonth * 12 + SalaryMonth * 2.5;
            double tax =  0.25 * yearIncome;
            double clearIncome = (yearIncome - tax) * DollarLv;
            double profitDay = clearIncome / 365;
            Console.WriteLine($"{profitDay:f2}");
            // or Console.WriteLine("{0:f2}, profitDay);
            
        }
    }
}

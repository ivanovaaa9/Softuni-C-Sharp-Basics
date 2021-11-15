using System;

namespace _100_DAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            string myDate = Console.ReadLine();

            DateTime answer = DateTime.ParseExact(myDate, "dd-MM-yyyy", null);

            Console.WriteLine(answer.AddDays(999).ToString("dd-MM-yyyy"));

        }
    }
}

using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCheckedBookd = 0;
            string searchedBook = Console.ReadLine();
            int countToatalBooks = int.Parse(Console.ReadLine());
            // see whether we have left books for checking
            while(countToatalBooks > 0)
            {
                string title = Console.ReadLine();
                if (title == searchedBook)
                {
                    Console.WriteLine($"You checked {countCheckedBookd} books and found it.");
                    break;
                }
                else
                {
                    countCheckedBookd++;
                }
                countToatalBooks--;
                
            }
            if (countToatalBooks <= 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countCheckedBookd} books.");
            }
        }
    }
}

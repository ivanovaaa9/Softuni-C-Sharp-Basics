using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double sum = double.Parse(Console.ReadLine());
           

            double countCash = 0;
            double countCard = 0;
            int count = 0;
            int count1 = 0;
            int count2 = 0;


            string command = Console.ReadLine();
            while (command != "End")
            {
                double price = double.Parse(command);
                count++;
                if (count % 2 != 0)
                {
                    if (price > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        countCard += price;
                        count2++;
                    }                    
                }
                else
                {
                    if (price < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        countCash += price;
                        count1++;
                    }
                }            
                    if (countCard + countCash >= sum)
                    {
                    Console.WriteLine($"Average CS: {(countCard / count2):f2}");

                    Console.WriteLine($"Average CC: {(countCash / count1):f2}");
                         break;
                    }
                    command = Console.ReadLine();
                }
                    if (command == "End")
                    {
                        Console.WriteLine("Failed to collect required money for charity.");
                    }                           
        }
    }
}
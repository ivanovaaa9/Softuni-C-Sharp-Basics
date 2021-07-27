using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            
            int counter = 0;
            bool noSpace = false;
            
            while (true)
            {
                string command = Console.ReadLine();
              
                if (command == "End")
                {
                    Console.WriteLine($"Congratulations! All suitcases are loaded!");
                    break;
                }
                double num = double.Parse(command);
                capacity = capacity - num;

                if (capacity <= 0)
                {
                    Console.WriteLine($"No more space!");
                    noSpace = true;
                    break;
                }
                counter++;

               if (num % 3 == 0)
                {
                    num *= 1.1;

                }
                            
            }
            if (!noSpace)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");

            }

            Console.WriteLine($"Statistic: {counter} suitcases loaded.");

            
            }
    }//90/100 judge
}

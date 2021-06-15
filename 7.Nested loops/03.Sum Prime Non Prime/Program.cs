using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();//num or stop
            
            int sumP = 0;
            int sumNP = 0;
            while (command != "stop")
            {
                int num = int.Parse(command); // num in form of text;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }
                //can put else here and skip the last 2 upward rows
                int count = 0;
                for(int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;//know the numbers of dividers
                    }
                }
                if (count == 2)
                {
                    sumP += num;
                }
                else if (count>2)
                {
                    sumNP += num;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumP}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNP}");

        }
    }
}

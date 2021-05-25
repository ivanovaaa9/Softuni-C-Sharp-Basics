using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
               /* if(input == "Paris")//when needed 2 conditions
                {
                    break;
                }*/
                input = Console.ReadLine();
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

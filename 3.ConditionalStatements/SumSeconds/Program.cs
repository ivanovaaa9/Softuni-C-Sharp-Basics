using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            //recieve total time in seconds
            //we need to convert it into min an seconds
            int tominutes = sum / 60;
            int timeSek = sum % 60;
            //print + check seconds - do we need 0 infront
            //% delenie s ostatyk
            //if seconds are less than 10 - put 0;
            if (timeSek < 10)
            {
                Console.WriteLine(tominutes + ":0" + timeSek);
            }
            else
            {
                Console.WriteLine(tominutes + ":" + timeSek);

            }
        }
    }
}

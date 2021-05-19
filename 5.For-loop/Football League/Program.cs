using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double numFans = double.Parse(Console.ReadLine());
            double numA = 0;
            double numB = 0;
            double numV = 0;
            double numG = 0;

            double percA = 0;
            double percB = 0;
            double percV = 0;
            double percG = 0;
            

            for (int i = 1; i <= numFans; i++)
            {
                char section = char.Parse(Console.ReadLine());
                if(section == 'A')
                {
                    numA ++;
                   percA= (numA / numFans) * 100;
                }
                if (section == 'B')
                {
                    numB++;
                    percB = (numB / numFans) * 100;
                }
                if (section == 'V')
                {
                    numV++;
                    percV = (numV / numFans) * 100;
                }
                if (section == 'G')
                {
                    numG++;
                    percG = (numG / numFans) * 100;
                }
                
            }
            double average = (numFans / capacity) * 100;
            Console.WriteLine($"{percA:f2}%");
            Console.WriteLine($"{percB:f2}%");
            Console.WriteLine($"{percV:f2}%");
            Console.WriteLine($"{percG:f2}%");
           
            Console.WriteLine($"{average:f2}%");
        }
    }
}

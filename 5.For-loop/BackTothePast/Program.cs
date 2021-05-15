using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int ageIvancho = 18;
            int oddY = 0;
            
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    heritage -= 12000;
                }
                else
                {                   
                    oddY = 12000+ageIvancho*50;

                    heritage = heritage - oddY;
                  }
                ageIvancho += 1;
            }
            
            if (heritage >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");
            }
            

        }
    }
}

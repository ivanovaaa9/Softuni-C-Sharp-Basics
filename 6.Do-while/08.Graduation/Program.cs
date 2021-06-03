using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();           
            double sum = 0;
            double grades = 1;
            while( grades <= 12)
            {
               double grade = double.Parse(Console.ReadLine());
                if (grade>= 4)
                {
                    sum += grade;
                    grades++;
                    
                }

            }
            if (grades == 13)
            {
                sum = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");

            }

        }
    }
}

using System;

namespace _09._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            double grades = 1;
            int fail = 0;
            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum += grade;
                    grades++;

                }if(grade < 4)
                {
                    fail++;
                    if (fail > 1) 
                    { break;
                    }

                    }

            }
            if (grades == 13)
            {
                sum = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");

            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grades} grade");

            }

        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            double five = 0;
            double four = 0;
            double three = 0;
            double two = 0;
            double twoP = 0;
            double threeP = 0;
            double fourP = 0;
            double fiveP = 0;
            double sumA = 0;
            double ss = 0;
        
            for (int i = 1; i <= numStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2.00 && grade <= 2.99)
                {
                    two++;
                    twoP = (two / numStudents) * 100;
                    sumA += grade;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    three++;
                    threeP = (three / numStudents) * 100;
                    sumA += grade;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    four++;
                    fourP = (four / numStudents) * 100;
                    sumA += grade;
                }
                else 
                {
                    five++;
                    fiveP = (five / numStudents) * 100;
                    sumA += grade;
                }
                ss = sumA / numStudents;
            }
          
            Console.WriteLine($"Top students: {fiveP:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourP:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeP:f2}%");
            Console.WriteLine($"Fail: {twoP:f2}%");
            Console.WriteLine($"Average: {ss:f2}");


        }
    }
}


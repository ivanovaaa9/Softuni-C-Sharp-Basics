using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJudges = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            double totalSum = 0;
            int countGrades = 0;
            while(text != "Finish")
            {
                double sum = 0;
                for(int i = 1; i <=countJudges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;

                    totalSum += grade;
                    countGrades++;
                    
                }
                double average = sum / countJudges;
                Console.WriteLine($"{text} - {average:f2}.");
                text = Console.ReadLine();
            }
            double nue = totalSum / countGrades;
            Console.WriteLine($"Student's final assessment is {nue:f2}.");
        }
    }
}

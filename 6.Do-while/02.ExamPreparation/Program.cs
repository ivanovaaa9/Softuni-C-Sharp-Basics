using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFnotGoodGrades = int.Parse(Console.ReadLine());//max not good grades
            int solvedTasks = 0;
            int notSatisfiedGrades = 0;
            double sum = 0;
            string lastTaks = " ";
            bool isFailed = true;
            while (notSatisfiedGrades < numOFnotGoodGrades)
            {
                string nameTask = Console.ReadLine();
               if(nameTask == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    notSatisfiedGrades++;
                }
                sum += grade;
                solvedTasks++;
                lastTaks = nameTask;

            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {notSatisfiedGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sum/solvedTasks:f2}");
                Console.WriteLine($"Number of problems: {solvedTasks}");
                Console.WriteLine($"Last problem: {lastTaks}");
            }
        }
    }
}

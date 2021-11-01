using System;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int tasks = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sumTasks = 0;
            int sum = 0;
            int questions=0;
            

            while (true)
            {
                for (int i = 1; i <= tasks; i++)
                {
                    energy += tasks * 2;
                    students -= tasks;

                     questions = students * 2;
                    energy -= questions * 3;
                    sumTasks++;
                    if (students < 10)
                    {
                        sum = sumTasks+questions;
                        Console.WriteLine("The students are too few!");
                        Console.WriteLine($"Problem solved: {sum}");
                        return;
                       }
                    else if (energy <= 0)

                    {
                        Console.WriteLine("Trainer is too tired!");
                        Console.WriteLine($"Questions asked: {questions}");
                        return;
                    }
                    else if (students % 10 == 0)
                    {
                        students++;
                    }

                }
                
            }
         


        }
    }
}

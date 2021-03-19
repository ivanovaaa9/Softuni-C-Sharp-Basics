using System;

namespace _05.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numProjects = int.Parse(Console.ReadLine());
            int hours = numProjects * 3;

            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {numProjects} project/s.");
        }
    }
}

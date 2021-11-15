using System;

namespace StudentGrades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());
            double firstExam = 0;
            double secondExam = 0;
            double continued = 0;
            double reSigned = 0;
            int studentNew = 0;
            int n = 0;
            int h = 0;



            for (int i = 1; i <= seasons; i++)
            {
                firstExam = students * 0.9;

                firstExam = (int)Math.Ceiling(firstExam);
                secondExam = firstExam * 0.9;
                secondExam = (int)Math.Ceiling(secondExam);
                continued = (secondExam * 0.8);
                n = (int)Math.Ceiling(continued);
                h = (int)Math.Ceiling(reSigned);
                if (i % 3 == 0)
                {
                    h += n * (15 / 100);
                }
                else
                {

                    h += n * (5 / 100);
                }

                studentNew = n + h;
                students = studentNew;
            }
            // double total = firstExam + secondExam + newss + reSigned;

            Console.WriteLine(students);
        }
    }
}

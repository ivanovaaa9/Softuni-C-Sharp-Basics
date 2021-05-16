using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;
            int n = int.Parse(Console.ReadLine());
            for (int number = 1; number <= n; number++){
                int value = int.Parse(Console.ReadLine());
                if(value < 200)
                {
                    group1++;
                }
                else if(value >=200&& value <= 399)
                {
                    group2++;
                }
                else if (value >= 400 && value <= 599)
                {
                    group3++;
                }
                else if (value >= 600 && value <= 799)
                {
                    group4++;
                }
                else if (value >= 800)
                {
                    group5++;
                }
            }
            double percent1 = group1 * 1.0 / n * 100;
            double percent2 = group2 * 1.0 / n * 100;
            double percent3 = group3 * 1.0 / n * 100;
            double percent4 = group4 * 1.0 / n * 100;
            double percent5 = group5 * 1.0 / n * 100;

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");


        }
    }
}

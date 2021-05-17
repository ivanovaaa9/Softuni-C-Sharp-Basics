using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = 0;
            int turns = int.Parse(Console.ReadLine());
            double f = 0;
            double s = 0;
            double t = 0;
            double fo = 0;
            double fif = 0;
            double six = 0;
            double fp = 0;
            double sp = 0;
            double tp = 0;
            double fop = 0;
            double fifp = 0;
            double sixp = 0;

            for (int i = 1; i <= turns; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num >= 0 && num <= 9)
                {
                    points += num * 0.2;
                    f++;
                    fp = (f / turns) * 100;

                }
                else if (num >= 10 && num <= 19)
                {
                    points += num * 0.3;
                    s++;
                    sp = (s / turns) * 100;
                }
                else if (num >= 20 && num <= 29)
                {
                    points += num * 0.4;
                    t++;
                    tp = (t / turns) * 100;
                }
                else if (num >= 30 && num <= 39)
                {
                    points += 50;
                    fo++;
                    fop = (fo / turns) * 100;
                }
                else if (num >= 40 && num <= 50)
                {
                    points += 100;
                    fif++;
                    fifp = (fif / turns) * 100;
                }
                else
                {
                    points = points / 2;
                    six++;
                    sixp = (six / turns) * 100;
                }
            }
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {fp:f2}%");
            Console.WriteLine($"From 10 to 19: {sp:f2}%");
            Console.WriteLine($"From 20 to 29: {tp:f2}%");
            Console.WriteLine($"From 30 to 39: {fop:f2}%");
            Console.WriteLine($"From 40 to 50: {fifp:f2}%");
            Console.WriteLine($"Invalid numbers: {sixp:f2}%");
        }
    }
}

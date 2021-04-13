using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int wholeNum = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (wholeNum <= 100)
            {
                bonus = 5;

            }
            else if (wholeNum > 1000)
            {
                bonus = 0.10 * wholeNum;

            }
            else if (wholeNum > 100)
            {
                bonus = 0.2 * wholeNum;
            }
            
            if (wholeNum % 2 == 0)
            {
                //even num
                //bonus up to now +1;
                bonus = bonus + 1;
            }
            else if (wholeNum % 10 == 5)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(wholeNum+bonus);
        }
    }
}

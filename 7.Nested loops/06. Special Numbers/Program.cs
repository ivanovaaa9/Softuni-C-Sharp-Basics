using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                int thousand = i / 1000;
                int hund = (i / 100) % 10;
                int tens = (i / 10) % 10;
                int units = i % 10;
                //if it is special
                bool chek1 =thousand!=0 && n % thousand == 0;
                bool check2 = hund != 0 && n % hund == 0;
                bool check3 = tens != 0 && n % tens == 0;
                bool check4 = units != 0 && n % units == 0;

                if (chek1 && check2 && check3 && check4)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

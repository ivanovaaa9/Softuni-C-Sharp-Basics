using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double change = double.Parse(Console.ReadLine());
            double changeinStotinki =Math.Floor(change * 100);
            while (changeinStotinki != 0)
            {
                if(changeinStotinki > 200)
                {
                    changeinStotinki -= 200;
                    count++;
                }
                else if (changeinStotinki >= 100)
                {
                    changeinStotinki -= 100;
                    count++;
                }
                else if (changeinStotinki >= 50)
                {
                    changeinStotinki -= 50;
                    count++;
                }
                else if (changeinStotinki >= 20)
                {
                    changeinStotinki -= 20;
                    count++;
                }
                else if (changeinStotinki >= 10)
                {
                    changeinStotinki -= 10;
                    count++;
                }
                else if (changeinStotinki >= 5)
                {
                    changeinStotinki -= 5;
                    count++;
                }
                else if (changeinStotinki >= 2)
                {
                    changeinStotinki -= 2;
                    count++;
                }
                else if (changeinStotinki >= 1)
                {
                    changeinStotinki -= 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

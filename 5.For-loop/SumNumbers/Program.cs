using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;// now no sum num
            for (int i = 1; i <= n; i++)
                //read n numbers, if sum was in for cycle it will be занулена всеки път цикълът се завърта., а ние искаме да я запазим
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            //sum them
            Console.WriteLine(sum);



        }
    }
}

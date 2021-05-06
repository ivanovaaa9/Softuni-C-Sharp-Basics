using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjections = Console.ReadLine();
            int numRows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;
            if(typeProjections == "Premiere")
            {
                income = numRows * columns * 12;
                Console.WriteLine("{0:f2} leva", income);
            }else if(typeProjections == "Normal")
            {
                income = numRows * columns * 7.5;
                Console.WriteLine("{0:f2} leva", income);
            }else if(typeProjections == "Discount")
            {
                income = numRows * columns * 5;
                Console.WriteLine("{0:f2} leva", income);
            }
            //can be only cw+tap tap at the end to avoid repetition

        }
    }
}

using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int bitcoin = int.Parse(Console.ReadLine());
            decimal chineseUian = decimal.Parse(Console.ReadLine());
            decimal comission = decimal.Parse(Console.ReadLine())/100.00m;

            int first = bitcoin * 1168;
            decimal dollar = chineseUian * 0.15m;
            decimal lv = dollar * 1.76m;
            decimal sum = first + lv;
            decimal euro = sum / 1.95m;
            euro -= euro * comission;
           
            Console.WriteLine(euro);*/
            int bitcoin = int.Parse(Console.ReadLine());
            double chineseUian = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            double com = comission / 100;

            int first = bitcoin * 1168;
            double dollar = chineseUian * 0.15;
            double lv = dollar * 1.76;
            double sum = first + lv;
            double euro = sum / 1.95;
            euro -= euro * com;
           
            Console.WriteLine(euro);




        }
    }
}

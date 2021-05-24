using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            double pricePlay = double.Parse(Console.ReadLine());

            //look through the bdays and create variables for money and gifts
            double moneyFromBdays = 0;
            double moneyGift = 10;
            //vriable for the toys
            int numToys = 0;

            for(int birthday = 1; birthday <= age; birthday++)
            {
                //bday =- even or odd
                if (birthday % 2 == 0)
                {
                    moneyFromBdays += moneyGift;
                    moneyGift += 10;
                    moneyFromBdays--;//for her bro
                }
                else
                {
                    numToys++;
                }

            }double TotalMoneyFrToys = numToys * pricePlay;
            double totalMoney = TotalMoneyFrToys + moneyFromBdays;
            if(totalMoney >= priceWash)
            {
                Console.WriteLine($"Yes! {(totalMoney - priceWash):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceWash - totalMoney):f2}");
            }
        }


        //additional
        /*
         int iterationCounter = 1;
         cw($"{iterationCounter} - {i}");
         iterationCounter++;*/
    }
}

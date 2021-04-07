using System;

namespace _06.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogNum = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());
           double priceDogsF = 2.50;
            double othersFood = 4;

            double finalDogs = dogNum * priceDogsF;
            double finalOthers = others * othersFood;
            double total = finalDogs + finalOthers;
            Console.WriteLine($"{total:F2} lv.");


        }
    }
}

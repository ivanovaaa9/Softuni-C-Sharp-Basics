using System;

namespace _07.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double Qmeter = double.Parse(Console.ReadLine());
            
            double priceForwholeYard = Qmeter * 7.61;
            double discountPrice = priceForwholeYard * 0.18;
            double finalPrice = priceForwholeYard - discountPrice;
            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($" The discount is: {discountPrice:F2} lv.");


        }
    }
}

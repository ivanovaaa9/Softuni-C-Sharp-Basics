using System;

namespace _03._Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double volumeLiters = volume * 0.001;
            double percentNumber = percent / 100; // take the percentage and transform it to a number
            double needLiters = volumeLiters * (1 - percentNumber); // obema - 1 za celiq aquarium - % in number
            // WHy 1 - from %  to a number  100/100 = 1
            Console.WriteLine($"{needLiters:F3}");



        }
    }
}

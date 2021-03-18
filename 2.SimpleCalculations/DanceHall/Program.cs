using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //one person = 7040 sm
            // free space / by one person space
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardropeSide = double.Parse(Console.ReadLine());
            double areaHall = (lenght * 100) * (width * 100); // in sm
            double bench = areaHall / 10;
            double wardrobe = (wardropeSide*100) * (wardropeSide*100); // * 100 to get from meters in santimeters;

            double empthySpace = areaHall - bench - wardrobe;
            double countPeople = empthySpace / 7040;

            Console.WriteLine(Math.Floor(countPeople));

            





            


        }
    }
}

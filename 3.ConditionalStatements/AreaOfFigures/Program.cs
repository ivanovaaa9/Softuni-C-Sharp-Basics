using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            if(figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                //double 
                area = side * side;
                //Console.WriteLine($"{area:f3}");
            }
            else if(figure == "rectangle")
            {

                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

               
               // double 
                    area = sideA * sideB;
                //Console.WriteLine($"{area:f3}");

            }
            else if (figure == "circle")
            {

                double radius = double.Parse(Console.ReadLine());

                 area = radius * radius * Math.PI;
                //double
                //Console.WriteLine($"{area:f3}");

            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                 area = side * height / 2;
                //double in fron of area, and delete the are in front declared;
                //Console.WriteLine($"{area:f3}");

            }


            Console.WriteLine($"{area:f3}");

            
        }
    }
}

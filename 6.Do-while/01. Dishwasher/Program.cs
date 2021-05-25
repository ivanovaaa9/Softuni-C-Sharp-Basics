using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {

            int numBottlesDeter = int.Parse(Console.ReadLine());
            //numBottlesDeter *= 750;
            string command = Console.ReadLine();
            int cDishes = 0;
            int cPots = 0;

            double dish = 0;//ml
            double pot = 0;
            int count = 0;
            int detergL = numBottlesDeter * 750;

            while (command != "End")
            {
                int numDishes = int.Parse(command);
                count++;

                if (count % 3 == 0)
                {

                    pot += numDishes;
                    cPots = numDishes * 15;
                    detergL -= cPots;
                }

                else
                {
                    dish += numDishes;
                    cDishes = numDishes * 5;
                    detergL -= cDishes;

                }

                if (detergL < 0)
                {


                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergL)} ml. more necessary!");

                    return;

                }
                command = Console.ReadLine();
            }

                if (detergL >= 0)
                {

                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{dish} dishes and {pot} pots were washed.");
                    Console.WriteLine($"Leftover detergent {detergL} ml.");

                }
            }


            }
        }
    

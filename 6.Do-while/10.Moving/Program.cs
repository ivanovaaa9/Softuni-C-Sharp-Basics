﻿using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * height * lenght;

            string command = Console.ReadLine();
            while(command!= "Done")
            {
                
                freeSpace -=int.Parse(command);
                if (freeSpace < 0)
                {

                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Done")// or check freeSpace >=0;
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            


        }
    }
}

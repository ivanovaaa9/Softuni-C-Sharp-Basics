﻿using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            int counter = 1;
            while(input!= password)
            {
                if(counter == 5)
                {
                    Console.WriteLine("Incorrect pass!!!!");
                    break;
                }
                input = Console.ReadLine();
                counter++;
            }
            if (input == password) {
                Console.WriteLine("Welcome " + username + "!");
            }

        }
    }
}

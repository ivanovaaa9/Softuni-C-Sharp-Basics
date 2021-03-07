using System;

namespace _01.GreetingsByName
{
    class Program
    {
        static void Main(string[] args)
        {
            //      int x = 5;
            //      int y = 10;
            //      double f = 5.5;
            //      char symbol = 'a';
            //      string text = "holla";
            //      Console.WriteLine();
            //      float number = 6.6f;
            //      decimal g = 8.8m;


            //      int age = int.Parse(Console.ReadLine());
            //      Console.WriteLine(age + 15);
            //
            //will show my age + 15 , how old s.o will be after 15 years.
            //int may be also declared as double.

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am " + age + "years old");



           
        }
    }
}

using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            // char pars-va in character - %,+,-,*,/,etc.
            
            switch (operation)
            {
                case '+':
                    int sum = num1 + num2;
                    //if result is evem - ..print atc "{N1} {оператор} {N2} = {резултат} – {even}
                    //if result is odd- prints ect."{N1} {оператор} {N2} = {резултат} – {odd}
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - odd");
                    }
                    break;
                case '-':
                    double diff = num1 - num2;
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {diff} - odd");
                    }

                    break;
                case '*':
                    double mix = num1 * num2;
                    if (mix % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {mix} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {mix} - odd");
                    }
                    break;
                case '/':
                    // chech if it n2 = 0, if it is we cannot divide bec in programming we cannot divide by 0
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        double divide = (num1*1.0) / num2;
                        Console.WriteLine($"{num1} / {num2} = {divide:f2}");
                    }
                    break;
                case '%':
                    if(num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        int div = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {div}");

                    }
                    break;

            }



        }
    }
}

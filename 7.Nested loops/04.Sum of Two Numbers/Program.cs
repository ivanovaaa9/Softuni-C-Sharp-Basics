using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRow = int.Parse(Console.ReadLine());
            int secondtRow = int.Parse(Console.ReadLine());
            int thirdRow = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFound = false;

            for (int i = firstRow; i <= secondtRow; i++)
            {

                for (int j = firstRow; j <= secondtRow; j++)
                {
                    counter++;
                    if (j + i == thirdRow)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {i + j})");

                        return;

                    }
                }
            }
                    if(!isFound)
                    {
                        Console.WriteLine($"{counter} combinations - neither equals {thirdRow}");
                        
                    }



                }

            }
           

        }
    


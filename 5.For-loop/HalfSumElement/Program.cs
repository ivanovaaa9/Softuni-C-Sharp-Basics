using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for(int wholeNum = 0; wholeNum <num; wholeNum++){
               int single =int.Parse(Console.ReadLine());
                sum = sum + single;
                
                if  (single>max)
                {
                    max = single;
                }
                int sumWithoutMax = sum - max;
                if(sumWithoutMax == max)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + max);
                }
                else
                {
                    int diff = Math.Abs(max - sumWithoutMax);
                    Console.WriteLine("No");
                        Console.WriteLine("Diff = " + diff);
                    
                }

            }
           
            


        }
    }
}

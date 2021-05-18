using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double water = 20;
            double net = 15;
            double others = 0;
            
            double water1 = 0;
            double net1 = 0;
            double others1 = 0;
            double neww1 = 0;


            for (int i = 1;i<=month; i++)
            {
               double electricity = double.Parse(Console.ReadLine());
               
                water1 += water;
                net1 += net;
                neww1 += electricity;
                others = (water + net + electricity) * 1.2;
                others1 += others;

                
            }
            double average = (water1 + net1 + neww1 + others1) / month;
            
            Console.WriteLine($"Electricity: {neww1:f2} lv");
            Console.WriteLine($"Water: {water1:f2} lv");
            Console.WriteLine($"Internet: {net1:f2} lv");
            Console.WriteLine($"Other: {others1:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");




        }
        
    }
}

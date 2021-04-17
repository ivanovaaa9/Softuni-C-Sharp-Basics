using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
             double income = double.Parse(Console.ReadLine());
              double grades = double.Parse(Console.ReadLine());
              double minwage = double.Parse(Console.ReadLine());
            double soc = minwage * 35 / 100;
            double Schgr = grades * 25;            
            if ( grades >= 5.5)
            {
                if (Schgr >= soc || income > minwage )        //  || or operator, check first after that second , but if first is not true it will not check the second  
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(Schgr));                
                else                
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(soc));                
            }            
             else if (income < minwage && grades > 4.5) // && highest priority, means AND
              {
                  
                  Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(soc));
              }
        
              else
              
                Console.WriteLine("You cannot get a scholarship!");
               
            
        }
    }
}

using System;

namespace _06.NumberinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            /* switch (num)
             {
                 case 0:
                     Console.WriteLine("No");
                         break;
                 default:
                     Console.WriteLine("Yes");
                     break;
             }*/
            //71/100.
            
            if (num >=-100 && num <= 100 && num !=0)
            {
                Console.WriteLine("Yes");
            }
            
            else
            {
                Console.WriteLine("No");
            }

            


        }
    }
}




using System;

namespace _01._Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-1000. For faster- but from 1 to 7 doesnt need to be checked , as well as after 997
            /* for(int number = 1; number <= 1000; number++)
              {
                  if(number % 10 == 7) // module division with rest 7 - ostatyk
                  {
                      Console.WriteLine(number);
                  }*/
            for (int number = 7; number <= 997; number += 10)
            {
                Console.WriteLine(number);
            }//or

        }
            

    }
}

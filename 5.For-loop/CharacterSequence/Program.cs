using System;

namespace _05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
           // string text = "SoftUni";
            // Console.WriteLine(text.Length);//7 
            //Console.WriteLine(text[2]);//f - because we start from 0;
            /*  Console.WriteLine(text[0]);
              Console.WriteLine(text[1]);
              Console.WriteLine(text[2]);
              Console.WriteLine(text[3]);
              Console.WriteLine(text[4]);
              Console.WriteLine(text[5]);
              ...... - use cycles*/

           /* for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(text[i]);
            }*/
            //or
           string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }

        }
    }
}

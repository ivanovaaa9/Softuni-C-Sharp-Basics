using System;

namespace _06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int value = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('a')){
                    value += 1;
                }
                if (text[i].Equals('e'))
                {
                    value += 2;
                }
                if (text[i].Equals('i'))
                {
                    value += 3;
                }
                if (text[i].Equals('o'))
                {
                    value += 4;
                }
                if (text[i].Equals('u'))
                {
                    value += 5;
                }
            }
            
            Console.WriteLine(value);
            }

        }
    }


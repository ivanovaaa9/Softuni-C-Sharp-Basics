using System;

namespace Book_pointInfigures
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool outRec1 = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            bool outRec2 = (x < h || x > 2 * h) || (y < h || y > 4 * h);

            bool inRec1 = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            bool inRec2 = (x > h && x < 2 * h) && (y > h && y < 4 * h);

            bool commonBorder = (x > h && x < 2 * h) && y == h;

            if (outRec1 && outRec2)
            {
                Console.WriteLine("outside");
            }else if ( inRec1 || inRec2 || commonBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}

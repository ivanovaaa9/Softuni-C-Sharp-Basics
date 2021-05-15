using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string weather = Console.ReadLine();
             switch (weather)
             {

                 case "sunny":
                     Console.WriteLine("Go for a walk.");
                     break;
                 case "windy":
                     Console.WriteLine("Go for a jacket.");
                     break;
                 case "snowy":
                     Console.WriteLine("Go for a ski.");
                     break;
                     
            обединяване --
            case "windy":
            case "snowy":
                     Console.WriteLine("Go for a ski.");
                     break;

             }*/
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }




































































        }
    }
}

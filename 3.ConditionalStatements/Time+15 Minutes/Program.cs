using System;

namespace _05.Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            DateTime time = new DateTime();
            time = time.AddHours(hour);
            time = time.AddMinutes(minutes + 15);
            Console.WriteLine(time.ToString("H:mm"));
            //Console.WriteLine("{0:H:mm}", time);*/


            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            if (minutes > 59)
            {
                minutes %= 60;
                hour += 1;


            }
            if (hour > 23)
            {
                hour %= 24;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");

        }
        }
    

}
            
            


       

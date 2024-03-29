﻿using System;

namespace _09.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examMinutes = examHour * 60 + examMinute; // hour exam
            int arriveMinutes = arriveHour * 60 + arriveMinute;//arrive hour

            if (arriveMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                int late = arriveMinutes - examMinutes;//late
                if (late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else 
                {
                    int lateHour = late / 60;
                    int lateMin = late % 60;

                    Console.WriteLine($"{lateHour}:{lateMin:D2} hours after the start"); 
                }
            }
            else if (arriveMinutes == examMinutes || examMinutes - arriveMinutes <= 30)
            {
                Console.WriteLine("On time");
                if(examMinutes - arriveMinutes <= 30&& examMinutes!=arriveMinutes)
                {
                    Console.WriteLine($"{examMinutes-arriveMinutes} minutes before the start");
                }
            }
            else if (examMinutes - arriveMinutes > 30)
            {
                Console.WriteLine("Early");
                //early less than an hour
                int early = examMinutes - arriveMinutes;
                if (early < 60)
                {
                    Console.WriteLine($"{early} minutes before the start");

                }else
                {
                    
                    int earlyHour = early / 60;
                    int earlyMin = early % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMin:D2} hours before the start");
                }
            }
        }
    }
}

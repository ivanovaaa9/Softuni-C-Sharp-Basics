using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentNum = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0.0;
            string sport = "";

            switch (season)
            {
                case "Winter":
                    if(groupType == "girls")
                    {
                        sport = "Gymnastics";
                        price = 9.60;

                    }
                    else if(groupType == "boys")
                    {
                        sport = "Judo";
                        price = 9.60;

                    }
                    else if(groupType == "mixed")
                    {
                        sport = "Ski";
                        price = 10;
                    }
                    break;
                case "Spring":
                    if (groupType == "girls")
                    {
                        sport = "Athletics";
                        price = 7.20;

                    }
                    else if (groupType == "boys")
                    {
                        sport = "Tennis";
                        price = 7.20;

                    }
                    else if (groupType == "mixed")
                    {
                        sport = "Cycling";
                        price = 9.50;
                    }
                    break;
                case "Summer":
                    if (groupType == "girls")
                    {
                        sport = "Volleyball";
                        price = 15;

                    }
                    else if (groupType == "boys")
                    {
                        sport = "Football";
                        price = 15;

                    }
                    else if (groupType == "mixed")
                    {
                        sport = "Swimming";
                        price = 20;
                    }
                    break;                   
            }
           price = price * studentNum * nights;
            if (studentNum >= 50)
            {
                price = price * 0.5;
            } if (studentNum >= 20 && studentNum < 50)
            {
                price = price -(price * 0.15);
            } if (studentNum >= 10 && studentNum < 20)
            {
                price = price - price * 0.05;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}

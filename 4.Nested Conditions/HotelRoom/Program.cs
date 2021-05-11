using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double apriceApartments = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = nights * 50;
                apriceApartments = nights * 65;
                //discount
                if(nights > 7 && nights <=14 )
                {
                    priceStudio = priceStudio - 0.05 * priceStudio;
                    // 0.95 * priceStudio;
                }else if(nights > 14)
                {
                    priceStudio = priceStudio - 0.30 * priceStudio;
                    //or 0.7 * priceStudio;
                }

            }
            else if (month == "June" || month == "September")
            {
                priceStudio = nights * 75.20;
                apriceApartments = nights * 68.70;
                if(nights > 14)
                {
                    priceStudio = priceStudio - 0.20 * priceStudio;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = nights * 76;
                apriceApartments = nights * 77;
            }

            if(nights > 14)
            {
                apriceApartments = apriceApartments - apriceApartments * 0.10;

            }
            // true for every month
            Console.WriteLine($"Apartment: {apriceApartments:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            
        }
    }
}

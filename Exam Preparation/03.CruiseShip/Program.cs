using System;

namespace CruiseShip
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string typeCruise = Console.ReadLine();
            string acommod = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;
            double totalDisc = 0;



            switch (typeCruise)
            {
                case "Mediterranean":
                    if (acommod == "standard cabin")
                    {
                        price = 27.50;


                    }
                    else if (acommod == "cabin with balcony")
                    {
                        price = 30.20;

                    }
                    else if (acommod == "apartment")
                    {
                        price = 40.50;

                    }
                    break;
                case "Adriatic":
                    if (acommod == "standard cabin")
                    {
                        price = 22.99;

                    }
                    else if (acommod == "cabin with balcony")
                    {
                        price = 25.00;

                    }
                    else if (acommod == "apartment")
                    {
                        price = 34.99;

                    }
                    break;
                case "Aegean":
                    if (acommod == "standard cabin")
                    {
                        price = 23.00;

                    }
                    else if (acommod == "cabin with balcony")
                    {
                        price = 26.60;

                    }
                    else if (acommod == "apartment")
                    {
                        price = 39.80;

                    }
                    break;
            }
            total = price * 4 * nights;
            if (nights > 7)
            {
                totalDisc = total - total * 0.25;
            }
            else
            {
                totalDisc = total;
            }
            Console.WriteLine($"Annie's holiday in the {typeCruise} sea costs {totalDisc:f2} lv.");
        }
    }
}

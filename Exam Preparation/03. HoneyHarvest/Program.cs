using System;

namespace _03._HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sunfl = 0;
            double daisy = 0;
            double lavender = 0;
            double mint = 0;
            double totalH = 0;
            double sunfllllll = 0;
            double daisyyyy = 0;
            double lavenderrrrr = 0;
            double mintttt = 0;
           

            switch (season)
            {
                case "Spring":
                    if (flower == "Sunflower")
                    {
                        sunfl += 10;
                        sunfllllll = sunfl * numFlowers;
                    }
                    else if (flower == "Daisy")
                    {
                        daisy += 12;
                        daisyyyy = daisy * numFlowers;
                        daisyyyy += daisyyyy * 0.1;
                    }
                    else if (flower == "Lavender")
                    {
                        lavender += 12;
                        lavenderrrrr = lavender * numFlowers;
                        
                    }
                    else if (flower == "Mint")
                    {
                        mint += 10;
                        mintttt = mint * numFlowers;
                        mintttt += mintttt * 0.1;
                    }
                    break;
                case "Summer":
                    if (flower == "Sunflower")
                    {
                        sunfl += 8 ;
                        sunfllllll = sunfl * numFlowers;
                        sunfllllll += sunfllllll * 0.1;
                    }
                    else if (flower == "Daisy")
                    {
                        daisy += 8;
                        daisyyyy = daisy * numFlowers; ;
                        daisyyyy += daisyyyy * 0.1;

                    }
                    if (flower == "Lavender")
                    {
                        lavender += 8;
                        lavenderrrrr = lavender * numFlowers;
                        lavenderrrrr += lavenderrrrr * 0.1;
                    }
                    if (flower == "Mint")
                    {
                        mint += 12;
                        mintttt = mint * numFlowers;
                        mintttt += mintttt * 0.1;
                    }
                    break;
                case "Autumn":
                    if (flower == "Sunflower")
                    {
                        sunfl += 12;
                        sunfllllll = sunfl * numFlowers;
                        sunfllllll -= sunfllllll * 0.05;
                    }
                    else if (flower == "Daisy")
                    {
                        daisy += 6;
                        daisyyyy = daisy * numFlowers;
                        daisyyyy -= daisyyyy * 0.05;

                    }
                   else if (flower == "Lavender")
                    {
                        lavender += 6;
                        lavenderrrrr = lavender * numFlowers;
                        lavenderrrrr -= lavenderrrrr * 0.05;

                    }
                   else if (flower == "Mint")
                    {
                        mint += 6;
                        mintttt = mint * numFlowers;
                        mintttt -= mintttt * 0.05;
                    }
                    break;

            }
            totalH = mintttt + lavenderrrrr + daisyyyy + sunfllllll;
            Console.WriteLine($"Total honey harvested: {totalH:f2}");
        }
    }
}

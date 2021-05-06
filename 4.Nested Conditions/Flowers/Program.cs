using System;


namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numH = int.Parse(Console.ReadLine());
            int numR = int.Parse(Console.ReadLine());
            int numL = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string fest = Console.ReadLine();

            double priceH = 0.0;
            double priceR = 0.0;
            double priceL = 0.0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceH = 2;
                    priceR = 4.10;
                    priceL = 2.50;

                    break;
                case "Autumn":
                case "Winter":
                    priceH = 3.75;
                    priceR = 4.50;
                    priceL = 4.15;
                    break;

            }
          
            double total = priceH * numH + priceL * numL + priceR * numR;

            switch (fest)
            {
                case "Y":
                    total = total + (total * 0.15);
                    break;
                case "N":
                    total = priceH * numH + priceL * numL + priceR * numR;
                    break;
            }
           

           if (numL > 7 && season == "Spring")
            {
                total = total - (total * 0.05);
            }

           else if (numR >= 10 && season == "Winter")
            {
                total = total - (total * 0.1);
            } 
              double totalN = numH + numL + numR;
            if (totalN > 20)
            {
                total = total - (total * 0.2);
            }
             double final = total + 2;
             Console.WriteLine($"{final:f2}");

            


        }
    }
}

using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            double sum = 0;
            double sumP = 0;
            double bus = 0;
            double tir = 0;
            double train = 0;
            int numLoad = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numLoad; i++)
            {
                int load = int.Parse(Console.ReadLine());
                if(load <= 3)
                {
                    price = 200 * load;
                    
                    bus += load;

                }else if(load >=4 && load <= 11)
                {
                    price = 175 * load;
                    tir += load;
                }
                else
                {
                    price = 120 * load;
                    train += load;
                }
                sum += load;
                sumP += price;
            }
            double mid = sumP / sum;
            Console.WriteLine($"{mid:f2}");
            bus = bus / sum * 100;
            Console.WriteLine($"{bus:f2}%");
            tir = tir / sum * 100;
            Console.WriteLine($"{tir:f2}%");
            train = train / sum * 100;
            Console.WriteLine($"{train:f2}%");
          

        }
    }
}

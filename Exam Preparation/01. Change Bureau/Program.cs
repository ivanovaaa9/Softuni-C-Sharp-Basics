using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double chineseJuan = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            int bitcoinValueBGN = 1168;
            double chineseJuanValueUSD = 0.15;           
            double USDBGN = 1.76;
            double EUROBGN = 1.95;
            double bitcoinV = bitcoin * bitcoinValueBGN;
            double Juan = chineseJuan * chineseJuanValueUSD;
            double JuanBgn = Juan * USDBGN;
            double sum = bitcoinV + JuanBgn;
            double sumEuro = sum / EUROBGN;
            double afterComission =sumEuro- sumEuro * (comission/100);
            Console.WriteLine($"{afterComission:f2}");









        }
    }
}

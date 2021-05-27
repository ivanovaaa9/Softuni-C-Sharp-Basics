using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            double countSpend = 0;//spend days
            int countTotalDays = 0; //spend ans save or do smth else
            while(availableMoney < tripPrice)
            {
                string action = Console.ReadLine();
                double sumSopendSave = double.Parse(Console.ReadLine());
                countTotalDays++;
                if(action == "save")
                {
                    availableMoney += sumSopendSave;
                    countSpend = 0;
                }
                else if( action == "spend")
                {
                    countSpend++;
                    availableMoney -= sumSopendSave;
                    if(availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                       
                }
                if (countSpend == 5)
                {
                    
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{countTotalDays}");
                    break;
                }  
            }
            if(availableMoney>= tripPrice)
            {
                Console.WriteLine($"You saved the money for {countTotalDays} days.");
            }
        }
    }
}

using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int win = 0;
            int lose = 0;
            double money = 0;

            for (int i = 1; i <= days; i++)
            {
                int countWin = 0;
                int countLose = 0;
                double dayMoney = 0;
                while (true)
                {
                    string sport = (Console.ReadLine());
                    if (sport == "Finish")
                    {
                        break;
                    }
                    string stage = Console.ReadLine();
                    if (stage == "win")
                    {
                        countWin++;
                        dayMoney += 20;
                    }
                    else if (stage == "lose")
                    {
                        countLose++;
                       // dayMoney -= 20;
                    }

                }
                if (countWin > countLose)
                {
                    dayMoney *= 1.1;
                    win++;
                }
                else
                {
                    lose++;
                }

                money += dayMoney;
            }
                if (win > lose)
                {
                money *= 1.2;
                    Console.WriteLine($"You won the tournament! Total raised money: {money:f2}");
                }
                else
                {
                    Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");

                }
            }
        }
    }



    




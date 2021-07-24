using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int musala = 0;
            int monblanck = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;
            int groupsNum = int.Parse(Console.ReadLine());
            for(int i = 1; i <= groupsNum; i++)
            {
                int people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    musala+=people;
                }else if (people >= 6 && people <= 12)
                {
                    monblanck+=people;
                }else if(people>=13&& people <= 25)
                {
                    kilimandjaro+=people;
                }
                else if(people>=26&& people <= 40)
                {
                    k2+=people;
                }else if (people >= 41)
                {
                    everest+=people;
                }
            }
            double sum = musala + monblanck + kilimandjaro + k2 + everest;

            double percentage1 = musala/sum * 100;
            double percentage2 = monblanck/sum * 100;
            double percentage3 = kilimandjaro/sum * 100;
            double percentage4 = k2/sum * 100;
            double percentage5 = everest/sum * 100;

            Console.WriteLine($"{percentage1:f2}%");
            Console.WriteLine($"{percentage2:f2}%");
            Console.WriteLine($"{percentage3:f2}%");
            Console.WriteLine($"{percentage4:f2}%");
            Console.WriteLine($"{percentage5:f2}%");
        }
    }
}

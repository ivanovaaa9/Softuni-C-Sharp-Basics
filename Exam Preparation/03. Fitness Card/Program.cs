using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;
            if (age <= 19)
            {
                if (sex == 'm')
                {
                    switch (sport)
                    {
                        case "Gym":
                            price +=42- 42*0.2;
                            break;
                        case "Boxing":
                            price +=41- 41*0.2;
                            break;
                        case "Yoga":
                            price +=45- 45*0.2;
                            break;
                        case "Zumba":
                            price +=34- 34*0.2;
                            break;
                        case "Dances":
                            price +=51- 51*0.2;
                            break;
                        case "Pilates":
                            price +=39- 39*0.2;
                            break;
                    }
                }
                else if (sex == 'f')
                {
                    switch (sport)
                    {

                        case "Gym":
                            price +=35- 35*0.2;
                            break;
                        case "Boxing":
                            price +=37- 37*0.2;
                            break;
                        case "Yoga":
                            price +=42- 42*0.2;
                            break;
                        case "Zumba":
                            price +=31- 31*0.2;
                            break;
                        case "Dances":
                            price +=53- 53*0.2;
                            break;
                        case "Pilates":
                            price +=37- 37*0.2;
                            break;

                    }
                }
            }
           else if (sex == 'm')
            {
                switch (sport)
                {
                    case "Gym":
                        price += 42;
                        break;
                    case "Boxing":
                        price += 41;
                        break;
                    case "Yoga":
                        price += 45;
                        break;
                    case "Zumba":
                        price += 34;
                        break;
                    case "Dances":
                        price += 51;
                        break;
                    case "Pilates":
                        price += 39;
                        break;
                }
            }
            else if (sex == 'f')
            {
                switch (sport)
                {

                    case "Gym":
                        price += 35;
                        break;
                    case "Boxing":
                        price += 37;
                        break;
                    case "Yoga":
                        price += 42;
                        break;
                    case "Zumba":
                        price += 31;
                        break;
                    case "Dances":
                        price += 53;
                        break;
                    case "Pilates":
                        price += 37;
                        break;

                }
            }
            if (sum > price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double newsss =Math.Abs(sum - price);
                Console.WriteLine($"You don't have enough money! You need ${newsss:f2} more.");
            }
            
        }
    }
}

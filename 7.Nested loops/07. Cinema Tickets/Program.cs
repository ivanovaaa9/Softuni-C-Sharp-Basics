using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double totalTicketsS = 0;
            double kidsTickets = 0;
            double studentTickets = 0;
            double standartTickets = 0;
            while (movieName != "Finish")
            {
                int seatsAvail = int.Parse(Console.ReadLine());
                string tickets = Console.ReadLine();
                int ticetscounter = 0;
                while (tickets != "End")
                {
                    switch (tickets)
                    {
                        case "kid":
                            kidsTickets++;
                            break;
                        case "standard":
                            standartTickets++;
                            break;
                        case "student":
                            studentTickets++;       
                            break;
                            
                    }
                    ticetscounter++;
                    if (ticetscounter == seatsAvail)
                    {
                        break;
                    }

                    tickets = Console.ReadLine();
                }
                totalTicketsS += ticetscounter;
                double seatsTaken = ticetscounter * 1.0 / seatsAvail * 100;
                Console.WriteLine($"{movieName} - {seatsTaken:f2}% full.");
                movieName = Console.ReadLine();
            }
            double kidPercent = kidsTickets / totalTicketsS * 100;
            double standartPercent = standartTickets / totalTicketsS * 100;
            double studentPercent = studentTickets / totalTicketsS * 100;


            Console.WriteLine($"Total tickets: {totalTicketsS}");
            Console.WriteLine($"{studentPercent:f2}% student tickets.");
            Console.WriteLine($"{standartPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidPercent:f2}% kids tickets.");

        }
    }
}

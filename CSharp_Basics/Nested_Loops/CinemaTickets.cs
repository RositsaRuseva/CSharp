using System;

namespace CinemaTickes
{
    class Program
    {
        static void Main(string[] args)
        {

            double standard = 0;
            double student = 0;
            double kid = 0;
           

           

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }
                double freeSeats = double.Parse(Console.ReadLine());
                double total = 0;


                while (true)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    if (ticketType == "standard")
                    {
                        standard++;
                    }
                    else if (ticketType == "student")
                    {
                        student++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                    }
                    total++;

                    if (total == freeSeats)
                    {
                        break;
                    }
                }
                double filledHallPerc = (total / freeSeats) * 100;
                Console.WriteLine($"{movieName} - {filledHallPerc:f2}% full.");
            }
            double totalTickets = standard + student + kid;
            double standarsTicketPerc = (standard / totalTickets) * 100;
            double studentTicketPerc = (student / totalTickets) * 100;
            double kidTicketPerc = (kid / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketPerc:f2}% student tickets.");
            Console.WriteLine($"{standarsTicketPerc:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketPerc:f2}% kids tickets.");
        }
    }
}

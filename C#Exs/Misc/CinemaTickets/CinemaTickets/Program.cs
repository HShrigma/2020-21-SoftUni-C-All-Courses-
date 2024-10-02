using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = "";
            string input = "";
            double freeSeats = 0;
            bool finish = false;
            double totalTickets = 0;
            double standardTickets = 0;
            double studentTickets = 0;
            double kidsTickets = 0;
            double studentPercentage = 0.0;
            double standardPercentage = 0.0;
            double kidsPercentage = 0.0;
            while (finish == false)
            {
                filmName = Console.ReadLine();
                if (filmName == "Finish")
                {
                    studentPercentage = (studentTickets / totalTickets) * 100;
                    standardPercentage = (standardTickets / totalTickets) * 100;
                    kidsPercentage = (kidsTickets / totalTickets) * 100;
                    Console.WriteLine($"Total tickets: {totalTickets}");
                    Console.WriteLine($"{studentPercentage:F2}% student tickets.");
                    Console.WriteLine($"{standardPercentage:F2}% standard tickets.");
                    Console.WriteLine($"{kidsPercentage:F2}% kids tickets.");
                    finish = true;
                    break;
                }
                freeSeats = double.Parse(Console.ReadLine());
                double ticketsSold = 0;
                input = "";
                while (input != "End")
                {
                    input = Console.ReadLine();
                    if (input == "End")
                    {
                        double filmPercent = (ticketsSold / freeSeats) * 100 ;
                        Console.WriteLine($"{filmName} - {filmPercent:F2}% full.");
                        break;
                    }
                    ticketsSold++;
                    totalTickets++;
                        if (input == "student")
                        {
                            studentTickets++;
                        }
                        if (input == "standard")
                        {
                            standardTickets++;
                        }
                        if (input == "kid")
                        {
                            kidsTickets++;
                        }
                    if (ticketsSold == freeSeats)
                    {
                        double filmPercent = (ticketsSold / freeSeats) * 100;
                        Console.WriteLine($"{filmName} - {filmPercent:F2}% full.");
                        break;
                    }
                }
            }
        }
    }
}

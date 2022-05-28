using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;
            string input = Console.ReadLine();

            while (input != "Finish")
            {
                int freeSpots = int.Parse(Console.ReadLine());
                int tickets = 0;
                string type = Console.ReadLine();
                while (type != "End")
                {
                    switch (type)
                    {
                        case "student":
                            studentTicket++;
                            break;
                        case "standard":
                            standardTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;
                    }

                    tickets++;
                    if (tickets == freeSpots)
                    {
                        break;
                    }
                    type = Console.ReadLine();
                }
                double percent = tickets * 100d / freeSpots;
                Console.WriteLine($"{input} - {percent:f2}% full.");
                input = Console.ReadLine();
            }

            int totalTickets = kidTicket + standardTicket + studentTicket;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTicket * 100d / totalTickets):f2}% student tickets.");
            Console.WriteLine($"{(standardTicket * 100d / totalTickets):f2}% standard tickets.");
            Console.WriteLine($"{(kidTicket * 100d / totalTickets):f2}% kids tickets.");
        }
    }
}

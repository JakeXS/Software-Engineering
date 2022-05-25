using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string location = "";
            double price = 0;

                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                    }
                    else
                    {
                        destination = "Europe";
                    }

            switch (destination)
            {
                case "Bulgaria":
                    if (season == "summer")
                    {
                        price = budget * 0.3;
                    }
                    else if (season == "winter")
                    {
                        price = budget * 0.7;
                    }
                    break;
                case "Balkans":
                    if (season == "summer")
                    {
                        price = budget * 0.4;
                    }
                    else if (season == "winter")
                    {
                        price = budget * 0.8;
                    }
                    break;
                case "Europe":
                    price = budget * 0.9;
                    break;
            }
                    if (destination == "Europe")
                    {
                        location = "Hotel";
                    }
                    else if(season == "summer")
                    {
                        location = "Camp";
                    }
                    else if(season == "winter")
                    {
                        location = "Hotel";
                    }
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{location} - {price:f2}");
            
        }
    }
}

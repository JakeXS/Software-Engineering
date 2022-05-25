using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000.0;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200.0;
                    break;
                case "Winter":
                    price = 2600.0;
                    break;
            }
            if(fisherman <= 6)
            {
                price *= 0.9;
            }
            else if(fisherman <= 11)
            {
                price *= 0.85;
            }
            else
            {
                price *= 0.75;
            }
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }
            Console.WriteLine(budget >= price ? $"Yes! You have {(budget - price):f2} leva left." : $"Not enough money! You need {(price - budget):f2} leva.");
        }
    }
}

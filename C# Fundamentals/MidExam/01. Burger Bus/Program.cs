using System;

namespace _01._Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            String city;
            double income = 0;
            double expenses = 0;
            double totalProfit = 0;
            for (int i = 1; i <= numberOfCities; i++)
            {
                city = Console.ReadLine();
                income = Double.Parse(Console.ReadLine());
                expenses = Double.Parse(Console.ReadLine());
                if (i % 3 == 0 && i != 15)
                {
                    expenses *= 1.5;
                }
                else if (i % 5 == 0)
                {
                    income *= 0.9;
                }
                double currentProfit = income - expenses;
                totalProfit += currentProfit;
                Console.WriteLine($"In {city} Burger Bus earned {currentProfit:f2} leva.");

            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}

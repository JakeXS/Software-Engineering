using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string review = Console.ReadLine();
            double price = 0;
            switch (roomType)
            {
                case "room for one person":
                    price = review == "positive" ? (18.0 * days) * 1.25 : (18.0 * days) * 0.9;
                    break;
                case "apartment":
                    price = days * 25.0;
                    if (days < 10)
                    {
                        price *= 0.7;
                    }
                    else if (days < 15)
                    {
                        price *= 0.65;
                    }
                    else
                    {
                        price *= 0.5;
                    }
                    price *= review == "positive" ? 1.25 : 0.9;
                    break;
                case "president apartment":
                    price = days * 35.0;
                    if (days < 10)
                    {
                        price *= 0.9;
                    }
                    else if (days < 15)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price *= 0.8;
                    }
                    price *= review == "positive" ? 1.25 : 0.9;
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}

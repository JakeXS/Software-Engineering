using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            switch (drink)
            {
                case "coffee":
                    if (town == "Sofia")
                    {
                        price = quantity * 0.5;
                    }
                    else if (town == "Plovdiv")
                    {
                        price = quantity * 0.4;
                    }
                    else if (town == "Varna")
                    {
                        price = quantity * 0.45;
                    }
                    break;
                case "water":
                    if (town == "Sofia")
                    {
                        price = quantity * 0.8;
                    }
                    else if (town == "Plovdiv")
                    {
                        price = quantity * 0.7;
                    }
                    else if (town == "Varna")
                    {
                        price = quantity * 0.7;
                    }
                    break;
                case "beer":
                    if (town == "Sofia")
                    {
                        price = quantity * 1.2;
                    }
                    else if (town == "Plovdiv")
                    {
                        price = quantity * 1.15;
                    }
                    else if (town == "Varna")
                    {
                        price = quantity * 1.1;
                    }
                    break;
                case "sweets":
                    if (town == "Sofia")
                    {
                        price = quantity * 1.45;
                    }
                    else if (town == "Plovdiv")
                    {
                        price = quantity * 1.3;
                    }
                    else if (town == "Varna")
                    {
                        price = quantity * 1.35;
                    }
                    break;
                case "peanuts":
                    if (town == "Sofia")
                    {
                        price = quantity * 1.6;
                    }
                    else if (town == "Plovdiv")
                    {
                        price = quantity * 1.5;
                    }
                    else if (town == "Varna")
                    {
                        price = quantity * 1.55;
                    }
                    break;
            }
            Console.WriteLine(price);
        }
    }
}

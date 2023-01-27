using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = 0;
            string input = Console.ReadLine();
            while (input != "Start")
            {
                var coin = double.Parse(input);
                switch (coin)
                {
                    case 2.0:
                        coins += coin;
                        break;
                    case 1.0:
                        coins += coin;
                        break;
                    case 0.5:
                        coins += coin;
                        break;
                    case 0.2:
                        coins += coin;
                        break;
                    case 0.1:
                        coins += coin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                input = Console.ReadLine();
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        if (coins-2.0>=0)
                        {
                            coins -= 2.0;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coins - 0.7 >= 0)
                        {
                            coins -= 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coins - 1.5 >= 0)
                        {
                            coins -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coins - 0.8 >= 0)
                        {
                            coins -= 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coins - 1.0 >= 0)
                        {
                            coins -= 1.0;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coins:f2}");
        }
    }
}

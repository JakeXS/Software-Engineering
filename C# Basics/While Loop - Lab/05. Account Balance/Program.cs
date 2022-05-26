using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;

            while (input != "NoMoreMoney")
            {
                double increase = double.Parse(input);
                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    total += increase;
                    Console.WriteLine($"Increase: {increase:f2}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}

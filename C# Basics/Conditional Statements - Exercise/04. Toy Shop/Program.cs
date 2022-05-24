using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double price = (puzzels * 2.6) + (dolls * 3.0) + (teddybears * 4.1) + (minions * 8.2) + (trucks * 2.0);
            int count = puzzels + dolls + teddybears + minions + trucks;
            if (count >= 50)
            {
                price *= 0.75;
            }
            price *= 0.9;
            if (price >= vacationPrice)
            {
                Console.WriteLine($"Yes! {(price - vacationPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(vacationPrice - price):F2} lv needed.");
            }
        }
    }
}

using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toyCount = 0;
            int evenBDays = 0;
            double savedMoney = 0;
            double toyMoney;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    evenBDays++;
                    savedMoney += 10 * evenBDays;
                }
                else
                {
                    toyCount++;
                }
            }

            toyMoney = toyCount * toyPrice;
            savedMoney += toyMoney - evenBDays;

            if (savedMoney >= price)
            {
                Console.WriteLine($"Yes! {(savedMoney - price):F2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(savedMoney - price):F2}");
            }

        }
    }
}

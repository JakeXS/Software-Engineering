using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double savedMoney = 0;
                double moneyNeeded = double.Parse(Console.ReadLine());
                while (savedMoney < moneyNeeded)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }

                
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}

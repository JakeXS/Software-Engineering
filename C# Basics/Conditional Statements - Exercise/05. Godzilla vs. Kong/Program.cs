using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double clothesPrice = extras * clothes;
            if (extras > 150)
            {
                clothesPrice *= 0.9;
            }
            budget *= 0.9;
            budget -= clothesPrice;
            if (budget >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget):F2} leva more.");
            }
        }
    }
}

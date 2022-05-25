using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            switch (flower)
            {
                case "Roses":
                    price = count > 80 ? (count * 5.0) * 0.9 : count * 5.0;
                    break;
                case "Dahlias":
                    price = count > 90 ? (count * 3.8) * 0.85 : count * 3.8;
                    break;
                case "Tulips":
                    price = count > 80 ? (count * 2.8) * 0.85 : count * 2.8;
                    break;
                case "Narcissus":
                    price = count >= 120 ? count * 3.0 : (count * 3.0) * 1.15;
                    break;
                case "Gladiolus":
                    price = count < 80 ? (count * 2.5) * 1.2 : count * 2.5;
                    break;
            }

            Console.WriteLine(budget >= price ? $"Hey, you have a great garden with {count} {flower} and {((budget * 1.0) - price):f2} leva left." : $"Not enough money, you need {(price - budget):f2} leva more.");

        }
    }
}

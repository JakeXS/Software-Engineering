using System;

namespace _01._Cat_Diet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fat = int.Parse(Console.ReadLine());
            int protein = int.Parse(Console.ReadLine());
            int carbohydrates = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            int water = int.Parse(Console.ReadLine());
            double fatGram = (fat / 100d * calories) / 9.0;
            double proteinGram = (protein / 100d * calories) / 4.0;
            double carbohydratesGram = (carbohydrates / 100d * calories) / 4.0;
            double foodWeight = carbohydratesGram + proteinGram + fatGram;
            double caloriesPerGram = (calories / foodWeight) * (1.0 - water/100d);
            Console.WriteLine($"{caloriesPerGram:f4}");
        }
    }
}

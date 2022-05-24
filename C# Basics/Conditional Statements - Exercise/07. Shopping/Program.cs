using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double gpuPrice, cpuPrice, ramPrice, totalPrice;

            gpuPrice = gpu * 250.0;
            cpuPrice = (gpuPrice * 0.35) * cpu;
            ramPrice = (gpuPrice * 0.1) * ram;
            totalPrice = gpuPrice + cpuPrice + ramPrice;

            if (gpu > cpu)
            {
                totalPrice *= 0.85;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {(budget - totalPrice):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
            }
        }
    }
}

using System;

namespace _04._Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kmRan = double.Parse(Console.ReadLine());
            double totalKm = kmRan;
            for (int i = 0; i < days; i++)
            {
                int increaseKm = int.Parse(Console.ReadLine());
                totalKm = totalKm + (kmRan * (1.0 + (increaseKm / 100d)));
                kmRan = kmRan * (1.0 + (increaseKm / 100d));

            }

            if (totalKm >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKm - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKm)} more kilometers");
            }
        }
    }
}

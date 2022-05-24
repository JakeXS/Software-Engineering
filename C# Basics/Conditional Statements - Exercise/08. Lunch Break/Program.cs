using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int epDuration = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double lunchTime = lunchBreak * 0.125;
            double freeTime = lunchBreak * 0.25;
            double timeLeft = lunchBreak - (lunchTime + freeTime);

            if (timeLeft >= epDuration)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - epDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(epDuration - timeLeft)} more minutes.");
            }
        }
    }
}

using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int time = firstTime + secondTime + thirdTime;
            int seconds = time % 60;
            int minutes = time / 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}

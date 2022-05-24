using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double mps = double.Parse(Console.ReadLine());

            double sec = distance * mps;
            double slow = Math.Floor(distance / 15) * 12.5;
            double time = sec + slow;

            if (record > time)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(time - record):F2} seconds slower.");
            }
        }
    }
}

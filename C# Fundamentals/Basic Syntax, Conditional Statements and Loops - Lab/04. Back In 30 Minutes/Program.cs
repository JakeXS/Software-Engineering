using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMin = hours * 60 + minutes + 30;
            int timeH = totalMin / 60;
            int timeM = totalMin % 60;
            if (timeH == 24)
            {
                timeH = 0;
            }

            Console.WriteLine($"{timeH}:{timeM:d2}");
        }
    }
}

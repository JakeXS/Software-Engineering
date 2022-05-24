using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int time = hours * 60 + minutes + 15;
            int newhours = time / 60;
            int newminutes = time % 60;
            if (newhours == 24)
            {
                newhours = 0;
            }


            Console.WriteLine($"{newhours}:{newminutes:D2}");
        }
    }
}

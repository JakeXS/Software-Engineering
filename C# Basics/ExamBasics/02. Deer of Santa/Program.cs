using System;

namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int absence = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodPerDayDeerOne = double.Parse(Console.ReadLine());
            double foodPerDayDeerTwo = double.Parse(Console.ReadLine());
            double foodPerDayDeerThree = double.Parse(Console.ReadLine());
            double foodNeeded = (absence * foodPerDayDeerOne) + (absence * foodPerDayDeerTwo) + (absence * foodPerDayDeerThree);
            if (food >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(food - foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - food)} more kilos of food are needed.");
            }
        }
    }
}

using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liquid = int.Parse(Console.ReadLine());
            int persent = int.Parse(Console.ReadLine());
            double total = ((pens * 5.8) + (markers * 7.2) + (liquid * 1.2)) * (1.0 - (persent / 100.0));
            Console.WriteLine(total);
        }
    }
}

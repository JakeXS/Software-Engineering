using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wrap = int.Parse(Console.ReadLine()) + 2;
            int paint = int.Parse(Console.ReadLine());
            int liquid = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double total = (wrap * 1.5) + ((paint * 1.1) * 14.5) + (liquid * 5.0) + 0.4;
            double worker = total * 0.3 * hours;
            Console.WriteLine(total + worker);
        }
    }
}

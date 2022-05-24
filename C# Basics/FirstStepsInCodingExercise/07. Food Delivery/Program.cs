using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegen = int.Parse(Console.ReadLine());
            double total = ((chicken * 10.35) + (fish * 12.4) + (vegen * 8.15)) * 1.2 + 2.5;
            Console.WriteLine(total);
        }
    }
}

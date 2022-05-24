using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double persent = double.Parse(Console.ReadLine());
            double waterV = (length * width * height) / 1000.0;
            double total = waterV * (1 - persent / 100.0);
            Console.WriteLine(total);
        }
    }
}

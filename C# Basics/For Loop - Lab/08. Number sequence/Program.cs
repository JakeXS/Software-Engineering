using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < input; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < min)
                {
                    min = n;
                }
                if (n > max)
                {
                    max = n;
                }

            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}

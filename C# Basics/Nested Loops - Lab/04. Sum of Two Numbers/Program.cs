using System;
using System.Dynamic;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isMagic = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magic)
                    {
                        isMagic = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
                        return;
                    }
                }
            }

            if (!isMagic)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}

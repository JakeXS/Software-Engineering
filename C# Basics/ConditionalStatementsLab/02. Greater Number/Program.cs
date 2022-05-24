using System;

namespace _02._Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine(a >= b ? a : b);
        }
    }
}

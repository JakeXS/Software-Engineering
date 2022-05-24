using System;

namespace _03._Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());


            Console.WriteLine(a % 2 == 0 ? "even" : "odd");
        }
    }
}

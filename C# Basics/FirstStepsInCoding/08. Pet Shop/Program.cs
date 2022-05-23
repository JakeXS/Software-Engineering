using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());
            float total = dog * 2.5f + cat * 4f;
            Console.WriteLine($"{total} lv.");
        }
    }
}

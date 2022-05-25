using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (movie)
            {
                case "Premiere":
                    totalPrice = rows * cols * 12.0;
                    break;
                case "Normal":
                    totalPrice = rows * cols * 7.5;
                    break;
                case "Discount":
                    totalPrice = rows * cols * 5.0;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}

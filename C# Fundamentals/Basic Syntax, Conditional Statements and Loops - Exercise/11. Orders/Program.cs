using System;
using System.Diagnostics;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                double orderPrice = 0;
                orderPrice = days * capsulePrice * count;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                totalPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

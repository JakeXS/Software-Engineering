using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float price = a * 7.61f;
            float discount = price * 0.18f;
            float totalPrice = price - discount;
            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}

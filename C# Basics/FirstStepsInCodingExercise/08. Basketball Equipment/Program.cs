using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            double boots, uniform, ball, accessories;
            boots = price * 0.6;
            uniform = boots * 0.8;
            ball = uniform * 0.25;
            accessories = ball * 0.2;
            double total = price + boots + uniform + ball + accessories;
            Console.WriteLine(total);
        }
    }
}

using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freeBelts = students / 6;
            int extraSabers = (int) Math.Ceiling(students * 0.1);
            double price = (students + extraSabers) * saberPrice + (students - freeBelts) * beltPrice + students * robesPrice;
            if (price <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(price - money):f2}lv more.");
            }
        }
    }
}

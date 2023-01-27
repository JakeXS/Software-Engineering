using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 2; i <= count; i++)
            {
                if (i % 2 == 0 && i % 3== 0)
                {
                    headsetCount++;
                    mouseCount++;
                    keyboardCount++;
                }
                else if (i % 3 == 0)
                {
                    mouseCount++;
                }
                else if (i % 2 == 0)
                {
                    headsetCount++;
                }
            }
            displayCount = keyboardCount / 2;
            double price = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}

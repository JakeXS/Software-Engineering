using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double endSum = sum + (time * (sum * (percent / 100) / 12));
            Console.WriteLine(endSum);
        }
    }
}

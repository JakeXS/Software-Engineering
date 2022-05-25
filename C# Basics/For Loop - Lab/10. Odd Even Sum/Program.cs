using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int oddSum = 0, evenSum = 0;
            for (int i = 1; i <= input; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += a;
                }
                else
                {
                    oddSum += a;
                }



            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}

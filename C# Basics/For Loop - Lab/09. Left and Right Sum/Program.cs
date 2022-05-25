using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int leftSum = 0, rightSum = 0;
            for (int i = 0; i < input * 2; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i < input)
                {
                    leftSum += a;
                }
                else
                {
                    rightSum += a;
                }



            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}

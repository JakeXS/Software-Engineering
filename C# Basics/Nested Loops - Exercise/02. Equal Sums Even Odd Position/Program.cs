using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                string curNum = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for (int j = 0; j < curNum.Length; j++)
                {
                    int curDigit = int.Parse(curNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += curDigit;
                    }
                    else
                    {
                        oddSum += curDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                        Console.Write($"{i} ");
                }
            }
        }
    }
}

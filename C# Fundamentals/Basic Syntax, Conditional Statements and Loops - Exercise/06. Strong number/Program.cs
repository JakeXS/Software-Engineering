using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = num;
            int fact = 1;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                for (int i = 1; i <= digit; i++)
                {
                    fact *= i;
                }
                sum += fact;
                fact = 1;
                num = num / 10;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

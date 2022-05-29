using System;

namespace _06._Multiply_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int firstDigit = int.Parse(number[2].ToString());
            int secondDigit = int.Parse(number[1].ToString());
            int thirdDigit = int.Parse(number[0].ToString());

            for (int i = 1; i <= firstDigit; i++)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= thirdDigit; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }

        }
    }
}

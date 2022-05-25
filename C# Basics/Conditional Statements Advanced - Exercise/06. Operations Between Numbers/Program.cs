using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            string evenOrOdd = "";

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{num1} + {num2} = {result} - {evenOrOdd}");
                    break;
                case '-':
                    result = num1 - num2;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{num1} - {num2} = {result} - {evenOrOdd}");
                    break;
                case '*':
                    result = num1 * num2;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{num1} * {num2} = {result} - {evenOrOdd}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 / (num2 * 1.0);
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    
                    break;

            }
        }
    }
}

﻿using System;
using System.ComponentModel;
using System.Numerics;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }

            }
        }
    }
}

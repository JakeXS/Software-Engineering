﻿using System;

namespace _01._Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            if (score >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}

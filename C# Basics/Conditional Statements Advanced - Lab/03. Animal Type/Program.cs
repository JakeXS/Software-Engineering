﻿using System;

namespace _03._Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            switch (input)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}

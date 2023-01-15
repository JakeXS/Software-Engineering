﻿using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string day = Console.ReadLine();
           int age = int.Parse(Console.ReadLine());
           int ticketPrice = 0;

           if (age >= 0 && age <= 18)
           {
               switch (day)
               {
                    case "Weekday":
                        ticketPrice = 12;
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        break;
                    case "Holiday":
                        ticketPrice = 5;
                        break;
               }
           }
           else if (age <= 64 && age > 18)
           {
               switch (day)
               {
                   case "Weekday":
                       ticketPrice = 18;
                       break;
                   case "Weekend":
                       ticketPrice = 20;
                       break;
                   case "Holiday":
                       ticketPrice = 12;
                       break;
               }
           }
           else if (age<=122 && age > 64)
           {
               switch (day)
               {
                   case "Weekday":
                       ticketPrice = 12;
                       break;
                   case "Weekend":
                       ticketPrice = 15;
                       break;
                   case "Holiday":
                       ticketPrice = 10;
                       break;
               }
           }
           else
           {
               Console.WriteLine("Error!");
               return;
           }

           Console.WriteLine($"{ticketPrice}$");
        }
    }
}

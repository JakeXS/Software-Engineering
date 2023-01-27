using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            switch (day)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":
                            totalPrice = count * 8.45;
                            if (count >= 30)
                            {
                                totalPrice *= 0.85;
                            }
                            break;
                        case "Business":
                            if (count >= 100)
                            {
                                totalPrice = count * 10.90 - 10 * 10.90;
                            }
                            else
                            {
                                totalPrice = count * 10.90;
                            }
                            break;
                        case "Regular":
                            totalPrice = count * 15.00;
                            if (count >= 10 && count <= 20)
                            {
                                totalPrice *= 0.95;
                            }
                            break;
                    }
                    break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students":
                            totalPrice = count * 9.80;
                            if (count >= 30)
                            {
                                totalPrice *= 0.85;
                            }
                            break;
                        case "Business":
                            if (count >= 100)
                            {
                                totalPrice = count * 15.60 - 10 * 15.60;
                            }
                            else
                            {
                                totalPrice = count * 15.60;
                            }
                            break;
                        case "Regular":
                            totalPrice = count * 20.00;
                            if (count >= 10 && count <= 20)
                            {
                                totalPrice *= 0.95;
                            }
                            break;
                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students":
                            totalPrice = count * 10.46;
                            if (count >= 30)
                            {
                                totalPrice *= 0.85;
                            }
                            break;
                        case "Business":
                            if (count >= 100)
                            {
                                totalPrice = count * 16.00 - 10 * 16.00;
                            }
                            else
                            {
                                totalPrice = count * 16.00;
                            }
                            break;
                        case "Regular":
                            totalPrice = count * 22.50;
                            if (count >= 10 && count <= 20)
                            {
                                totalPrice *= 0.95;
                            }
                            break;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

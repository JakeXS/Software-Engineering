using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double result = 0.0;
            if (sales >= 0 && sales <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 0.05;
                        break;
                    case "Varna":
                        result = sales * 0.045;
                        break;
                    case "Plovdiv":
                        result = sales * 0.055;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 0.07;
                        break;
                    case "Varna":
                        result = sales * 0.075;
                        break;
                    case "Plovdiv":
                        result = sales * 0.08;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 0.08;
                        break;
                    case "Varna":
                        result = sales * 0.10;
                        break;
                    case "Plovdiv":
                        result = sales * 0.12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else if (sales > 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 0.12;
                        break;
                    case "Varna":
                        result = sales * 0.13;
                        break;
                    case "Plovdiv":
                        result = sales * 0.145;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("error");
            }
            if (result != 0)
            {
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}

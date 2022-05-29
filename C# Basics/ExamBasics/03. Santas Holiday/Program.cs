using System;

namespace _03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stay = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string review = Console.ReadLine();
            double price = 0;

            switch (roomType)
            {
                case "room for one person":
                    price = stay * 18.0;
                    break;
                case "apartment":
                    if (stay < 10)
                    {
                        price = (stay * 25.0) * 0.7;
                    }
                    else if (stay <= 15)
                    {
                        price = (stay * 25.0) * 0.65;
                    }
                    else
                    {
                        price = (stay * 25.0) * 0.5;
                    }
                    break;
                case "president apartment":
                    if (stay < 10)
                    {
                        price = (stay * 35.0) * 0.9;
                    }
                    else if (stay <= 15)
                    {
                        price = (stay * 35.0) * 0.85;
                    }
                    else
                    {
                        price = (stay * 35.0) * 0.8;
                    }
                    break;
            }

            if (review == "positive")
            {
                Console.WriteLine($"{(price*1.25):f2}");
            }
            else
            {
                Console.WriteLine($"{(price*0.9):f2}");
            }
        }
    }
}

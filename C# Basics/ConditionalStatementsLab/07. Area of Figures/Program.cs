using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double a, b, h, r, S = 0;

            switch (type)
            {
                case "square":
                    a = double.Parse(Console.ReadLine());
                    S = a * a;
                    break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    S = a * b;
                    break;
                case "circle":
                    r = double.Parse(Console.ReadLine());
                    S = r * r * Math.PI;
                    break;
                case "triangle":
                    b = double.Parse(Console.ReadLine());
                    h = double.Parse(Console.ReadLine());
                    S = b * 0.5 * h;
                    break;
            }

            Console.WriteLine(String.Format("{0:0.000}", S));
        }
    }
}

using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1, p2, p3, p4, p5;
            int c1, c2, c3, c4, c5;
            c1 = c2 = c3 = c4 = c5 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    c1++;
                }
                else if (number < 400)
                {
                    c2++;
                }
                else if (number < 600)
                {
                    c3++;
                }
                else if (number < 800)
                {
                    c4++;
                }
                else
                {
                    c5++;
                }
            }

            p1 = c1 / (n * 1.0) * 100.0;
            p2 = c2 / (n * 1.0) * 100.0;
            p3 = c3 / (n * 1.0) * 100.0;
            p4 = c4 / (n * 1.0) * 100.0;
            p5 = c5 / (n * 1.0) * 100.0;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}

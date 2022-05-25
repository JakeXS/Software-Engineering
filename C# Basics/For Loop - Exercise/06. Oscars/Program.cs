using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double score = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string jury = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                score += (points * jury.Length) / 2.0;
                if (score > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {score:F1}!");
                    break;
                }

                if (i == n - 1 && score < 1250.5)
                {
                    Console.WriteLine($"Sorry, {name} you need {(1250.5 - score):F1} more!");
                }
            }
        }
    }
}

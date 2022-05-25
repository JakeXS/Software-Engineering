using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int score = int.Parse(Console.ReadLine());
            int winCount = 0;
            int points = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string standing = Console.ReadLine();

                switch (standing)
                {
                    case "W":
                        winCount++;
                        points += 2000;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                }
            }

            score += points;
            Console.WriteLine($"Final points: {score}");
            Console.WriteLine($"Average points: {Math.Floor(points / (tournaments * 1.0))}");
            Console.WriteLine($"{(winCount / (tournaments * 1.0) * 100.0):F2}%");
        }
    }
}

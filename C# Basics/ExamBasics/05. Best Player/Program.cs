using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxGoals = int.MinValue;
            bool didHatTrick = false;
            string bestPlayer = "";

            while (input != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = input;
                }

                if (goals >= 3)
                {
                    didHatTrick =true;
                }

                if (goals >= 10)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (didHatTrick)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}

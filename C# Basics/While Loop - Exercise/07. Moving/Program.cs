using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = height * width * length;

            while (volume >= 0)
            {
                string boxes = Console.ReadLine();
                if (boxes == "Done")
                {
                    break;
                }

                int boxesCount = int.Parse(boxes);
                volume -= boxesCount;

            }

            if (volume < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
        }
    }
}

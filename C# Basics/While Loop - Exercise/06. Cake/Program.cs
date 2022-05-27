using System;
using System.Dynamic;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakePieces = width * length;

            while (cakePieces > 0)
            {
                string piece = Console.ReadLine();
                if (piece == "STOP")
                {
                    break;
                }
                int pieceCount = int.Parse(piece);
                cakePieces -= pieceCount;
            }

            if (cakePieces >= 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}

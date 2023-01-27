using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startSeq = int.Parse(Console.ReadLine());
            int endSeq = int.Parse(Console.ReadLine());
            int seqSum = 0;

            for (int i = startSeq; i <= endSeq; i++)
            {
                Console.Write(i + " ");
                seqSum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {seqSum}");
        }
    }
}

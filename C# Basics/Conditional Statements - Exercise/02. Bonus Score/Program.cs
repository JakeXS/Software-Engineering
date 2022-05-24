using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPts = int.Parse(Console.ReadLine());
            double bonusPts = 0;
            if (startingPts <= 100)
            {
                bonusPts = 5;
            }
            else if (startingPts <= 1000)
            {
                bonusPts = startingPts * 0.2;
            }
            else
            {
                bonusPts = startingPts * 0.1;
            }
            if (startingPts % 2 == 0)
            {
                bonusPts += 1;
            }
            if (startingPts % 10 == 5)
            {
                bonusPts += 2;
            }

            Console.WriteLine(bonusPts);
            Console.WriteLine(startingPts + bonusPts);
        }
    }
}

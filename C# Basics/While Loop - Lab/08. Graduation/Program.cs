using System;
using System.Dynamic;
using System.Reflection;
using System.Threading.Channels;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double totalScore = 0;
            int fail = 0;

            while (grade <= 12)
            {
                double score = double.Parse(Console.ReadLine());
                if (score >= 4)
                {
                    totalScore += score;
                }
                else
                {
                    fail++;
                    totalScore += score;
                }

                if (fail == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade-1} grade");
                    return;
                }

                grade++;
            }

            double averageScore = totalScore / 12.0;
            Console.WriteLine($"{name} graduated. Average grade: {averageScore:f2}");

        }
    }
}

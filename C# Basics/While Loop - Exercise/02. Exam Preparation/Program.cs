using System;
using System.Threading.Channels;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int negativeScores = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            
            double avarageGrade = 0;
            int gradeCounter = 0;
            int negativeCounter = 0;
            string lastProblemName = "";
            while (problemName != "Enough")
            {
                double grade = double.Parse(Console.ReadLine());
                lastProblemName = problemName;
                if (grade <= 4)
                {
                    negativeCounter++;
                }

                if (negativeCounter == negativeScores)
                {
                    Console.WriteLine($"You need a break, {negativeScores} poor grades.");
                    return;
                }

                avarageGrade += grade;
                gradeCounter++;
                problemName = Console.ReadLine();
            }

            avarageGrade /= gradeCounter;

            Console.WriteLine($"Average score: {avarageGrade:f2}");
            Console.WriteLine($"Number of problems: {gradeCounter}");
            Console.WriteLine($"Last problem: {lastProblemName}");
        }
    }
}

using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double presentationScore = 0;
            int counter = 0;
            double avarageGrade = 0;

            while (input != "Finish")
            {
                for (int i = 1; i <= n; i++)
                {
                    presentationScore += double.Parse(Console.ReadLine());
                }

                presentationScore /= n;
                Console.WriteLine($"{input} - {presentationScore:f2}.");
                avarageGrade += presentationScore;
                counter++;
                presentationScore = 0;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {(avarageGrade/counter):f2}.");
        }
    }
}

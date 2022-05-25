using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHrs = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHrs = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            int totalExamMin = examHrs * 60 + examMin;
            int totalArrivalMin = arrivalHrs * 60 + arrivalMin;
            int difference = totalExamMin - totalArrivalMin;
            if (difference < 0)
            {
                Console.WriteLine("Late");
                if (Math.Abs(difference) > 59)
                {
                    Console.WriteLine($"{Math.Abs(difference) / 60}:{Math.Abs(difference) % 60 :d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                
            }
            else if(difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if(difference > 30)
            {
                Console.WriteLine("Early");
                if (Math.Abs(difference) > 59)
                {
                    Console.WriteLine($"{difference / 60}:{difference % 60:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
                }
            }
        }
    }
}

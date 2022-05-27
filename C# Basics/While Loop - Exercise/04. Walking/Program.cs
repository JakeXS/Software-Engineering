using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            bool isGoimgHome = false;
            
            while (totalSteps < 10000)
            { 
                string step = Console.ReadLine();
                if (step == "Going home")
                {
                    isGoimgHome = true;
                    continue;
                }
                
                totalSteps += int.Parse(step);
                if (isGoimgHome == true)
                {
                    break;
                }

            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}

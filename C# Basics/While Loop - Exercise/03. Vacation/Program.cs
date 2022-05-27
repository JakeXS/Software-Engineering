using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            int didSave = 0;
            int dayCounter = 0;
            
            while (savedMoney < moneyNeeded && didSave < 5)
            {
                dayCounter++;
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (action == "save")
                {
                    didSave = 0;
                    savedMoney += sum;
                }
                else if (action == "spend")
                {
                    didSave++;
                    savedMoney -= sum;
                }

                if (savedMoney < 0)
                {
                    savedMoney = 0;
                }
            }

            if (didSave == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCounter);
            }
            else
            {
                Console.WriteLine($"You saved the money for {dayCounter} days."); 
            }
        }
    }
}

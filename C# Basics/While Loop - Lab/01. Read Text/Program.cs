using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "Stop")
                {
                    Console.WriteLine(input);
                }
                else
                {
                    break;
                }
            }
        }
    }
}

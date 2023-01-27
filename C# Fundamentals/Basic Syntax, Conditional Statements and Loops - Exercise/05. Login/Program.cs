using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            foreach (var c in username)
            {
                password = c + password;
            }

            int attempts = 4;
            while (attempts != 0)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    attempts--;
                    if (attempts!=0)
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }
                }
                
            }

            if (attempts == 0)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}

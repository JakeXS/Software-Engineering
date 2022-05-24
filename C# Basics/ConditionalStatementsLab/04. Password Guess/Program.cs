using System;

namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();


            Console.WriteLine(pass == "s3cr3t!P@ssw0rd" ? "Welcome" : "Wrong password!");
        }
    }
}

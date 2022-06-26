using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main()
        {
            List<String> friends = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            int countBlacklisted = 0;
            int countLost = 0;
            while (input != "Report")
            {
               string[] tokens = input.Split().ToArray();
               if (tokens[0] == "Blacklist")
               {
                   bool changed = false;
                   for (int i = 0; i < friends.Count; i++)
                   {
                       
                       if (friends[i].Contains(tokens[1]))
                       {
                           friends[i] = "Blacklisted";
                           countBlacklisted++;
                           changed = true;
                       }

                       
                   }
                   if (changed)
                   {
                       Console.WriteLine($"{tokens[1]} was blacklisted.");
                   }
                   else
                   {
                        Console.WriteLine($"{tokens[1]} was not found."); 
                   }
               }
               else if (tokens[0] == "Error")
               {
                   int i = int.Parse(tokens[1]);
                   if (i >= 0 && i < friends.Count && friends[i] != "Blacklisted" && friends[i] != "Lost")
                   {
                       string oldName = friends[i];
                       friends[i] = "Lost";
                       countLost++;
                       Console.WriteLine($"{oldName} was lost due to an error.");

                   }
               }else if (tokens[0] == "Change")
               {
                   int i = int.Parse(tokens[1]);
                   if (i < friends.Count && i >= 0)
                   {
                       string oldName = friends[i];
                       friends[i] = tokens[2];
                       Console.WriteLine($"{oldName} changed his username to {tokens[2]}.");
                   }
               }

               input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {countBlacklisted}");
            Console.WriteLine($"Lost names: {countLost}");
            Console.WriteLine(String.Join(" ",friends));
        }
    }
}

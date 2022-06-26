using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var chat = new List<string>();
            while (input != "end")
            {
                string[] tokens = input.Split(' ').ToArray();
                if (tokens[0] == "Chat")
                {
                    chat.Add(tokens[1]);
                }
                else if (tokens[0] == "Delete")
                {
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (chat[i] == tokens[1])
                        {
                            chat.Remove(chat[i]);
                            break;
                        }
                    }
                }
                else if (tokens[0] == "Edit")
                {
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (chat[i] == tokens[1])
                        {
                            chat[i] = tokens[2];
                            break;
                        }
                    }
                }
                else if (tokens[0] == "Pin")
                {
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (chat[i] == tokens[1])
                        {
                            chat.Remove(chat[i]);
                            chat.Add(tokens[1]);
                            break;
                        }
                    }

                }
                else if(tokens[0] == "Spam")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        chat.Add(tokens[i]);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var text in chat)
            {
                Console.WriteLine(text);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Fund_Mid_Exam_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            List<string> pinned = new List<string>();

            string input = string.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();

                string[] command = input.Split();

                switch (command[0])
                {
                    case "Chat":
                        
                        chat.Add(command[1]);

                        break;

                    case "Delete":
                        
                        chat = DeleteIfExists(chat, command);

                        break;

                    case "Edit":
                        
                        chat = FindAndEdit(chat, command);

                        break; 

                    case "Pin":

                        chat.Add(command[1]);

                        chat.Remove(command[1]);

                        break;
                    
                    case "Spam":

                        chat = AddSpam(chat, command);
                        
                        break;

                    default:
                        break;
                }
            }

            foreach (var element in chat)
            {
                Console.WriteLine(element);
            }
        }
        static List<string> DeleteIfExists(List<string> toCheck, string[] command)
        {
            bool exists = false;
            
            foreach (var message in toCheck)
            {
                if (message == command[1])
                {
                    exists = true;
                }
            }

            if (exists)
            {
                toCheck.Remove(command[1]);
            }

            return toCheck;
        }

        static List<string> FindAndEdit(List<string> toEdit, string[] command)
        {
            for(int i = 0; i < toEdit.Count; i++)
            {
                if ( toEdit[i] == command[1])
                {
                    toEdit[i] = command[2];

                    break;
                }
            }

            return toEdit;
        }

        static List<string> AddSpam(List<string> add, string[] command)
        {
            for (int i = 1; i < command.Length; i++)
            {
                add.Add(command[i]);
            }
            return add;
        }
    }
}

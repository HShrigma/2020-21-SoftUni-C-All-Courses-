using System;
using System.Collections.Generic;
using System.Linq;

namespace Softuni_Fund_Final_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string input = string.Empty;

            while (input != "Sign up")
            {
                input = Console.ReadLine();

                string[] command = input.Split();

                switch (command[0])
                {
                    case "Case":
                        
                        if (command[1] == "upper")
                        {
                            username = username.ToUpper();
                        }

                        else
                        {
                            username = username.ToLower();
                        }

                        Console.WriteLine(username);
                        break;

                    case "Reverse":

                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        
                        if (startIndex >= 0 && startIndex <= endIndex && endIndex < username.Length)
                        {
                            if (endIndex - startIndex == 0)
                            {
                                Console.WriteLine(username[startIndex]);
                            }

                            else
                            {
                                string reverse = username.Substring(startIndex, (endIndex + 1) - startIndex);
                                char[] reversed = reverse.Reverse().ToArray();
                                Console.WriteLine(string.Join("",reversed));
                            }

                        }
                        break;

                    case "Cut":
                        string toCut = command[1];
                        
                        if (username.Contains(toCut))
                        {
                            username = username.Remove(username.IndexOf(toCut), toCut.Length);
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The word {username} doesn't contain {toCut}.");
                        }
                        break;

                    case "Replace":
                        char toReplace = char.Parse(command[1]);
                        List<char> newUsername = new List<char>();
                        
                        for (int i = 0; i < username.Length; i++)
                        {
                            if (username[i] == toReplace)
                            {
                                newUsername.Add('*');
                            }
                           
                            else
                            {
                                newUsername.Add(username[i]);
                            }
                        }
                        
                        username = new string(newUsername.ToArray());

                        Console.WriteLine(username);

                        break;

                    case "Check":
                        if (username.Contains(char.Parse(command[1])))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {char.Parse(command[1])}.");
                        }
                        break;
                        
                    default:
                        break;
                }
            }
        }
    }
}

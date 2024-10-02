using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Fund_Final_03
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            string input = string.Empty;

            while (input != "Log out")
            {
                input = Console.ReadLine();

                string[] command = input.Split(": ");

                switch (command[0])
                {
                    case "New follower":

                        if (users.ContainsKey(command[1]))
                        {
                            break;
                        }

                        else
                        {
                            users = AddKeyValuePairWith0ForeachValue(users, command[1]);
                        }

                        break;

                    case "Like":

                        if (users.ContainsKey(command[1]))
                        {
                            users[command[1]].Likes += int.Parse(command[2]);
                        }

                        else
                        {
                            users = AddKeyValuePairWith0ForeachValue(users, command[1]);

                            users[command[1]].Likes += int.Parse(command[2]);
                        }

                        break;

                    case "Comment":

                        if (users.ContainsKey(command[1]))
                        {
                            users[command[1]].Comments++;
                        }

                        else
                        {
                            users = AddKeyValuePairWith0ForeachValue(users, command[1]);

                            users[command[1]].Comments++;
                        }

                        break;

                    case "Blocked":
                        
                        if (users.ContainsKey(command[1]) == false)
                        {
                            Console.WriteLine($"{command[1]} doesn't exist.");
                        }

                        else
                        {
                            while (users.ContainsKey(command[1]))
                            {
                                users.Remove(command[1]);
                            }
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"{users.Count} followers");

            foreach (var user in users.OrderByDescending(n => n.Value.LikeCommentSum(n.Value.Likes, n.Value.Comments)).ThenBy(n => n.Key))
            {
                int sum = user.Value.LikeCommentSum(user.Value.Likes, user.Value.Comments);
                Console.WriteLine($"{user.Key}: {sum}");
            }
        }

        static Dictionary<string, User> AddKeyValuePairWith0ForeachValue(Dictionary<string, User> dict, string NameToAdd)
        {
            User temp = new User()
            {
                Likes = 0,
                Comments = 0
            };

            dict.Add(NameToAdd, temp);

            return dict;
        }
    }

    class User
    {
        public int Likes { get; set; }
        public int Comments { get; set; }

        public int LikeCommentSum(int likes, int comments) 
        {
            return likes + comments;
        }
    }
}

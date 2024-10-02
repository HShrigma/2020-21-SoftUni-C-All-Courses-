using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercises_04_List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> toOperateOn = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while (input != "End")
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] command = input
                    .Split();

                switch (command[0])
                {
                    case "Add":
                        
                        toOperateOn.Add(int.Parse(command[1]));
                        
                        break;
                    
                    case "Insert":
                        if (CheckValidIndex(toOperateOn, command) == false)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        else 
                        {
                            toOperateOn.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        break;
                    case "Remove":
                        
                        if (CheckValidIndex(toOperateOn, command) == false)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        else
                        {
                            toOperateOn.RemoveAt(int.Parse(command[1]));
                        }

                        break;
                    case "Shift":
                        switch (command[1])
                        {
                            case "left":
                                
                                toOperateOn = ShiftLeft(toOperateOn, command);
                                break;
                            
                            case "right":

                                toOperateOn = ShiftRight(toOperateOn, command);
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", toOperateOn));
        }

        static bool CheckValidIndex(List<int> toCheck, string[] command)
        {
            
            if (command[0] == "Insert")
            {
                if (int.Parse(command[2]) < 0 || int.Parse(command[2]) > toCheck.Count - 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > toCheck.Count - 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        static List<int> ShiftLeft(List<int> toShift, string[] command)
        {
            for (int i = 0; i < int.Parse(command[2]); i++)
            {
                toShift.Add(toShift[0]);
                toShift.RemoveAt(0);
            }
            return toShift; 
        }
        
        static List<int> ShiftRight(List<int> toShift, string[] command)
        {
            for (int i = 0; i < int.Parse(command[2]); i++)
            {
                toShift.Insert(0, toShift[(toShift.Count - 1)]);
                toShift.RemoveAt(toShift.Count - 1);
            }
            return toShift; 
        }
    }
}

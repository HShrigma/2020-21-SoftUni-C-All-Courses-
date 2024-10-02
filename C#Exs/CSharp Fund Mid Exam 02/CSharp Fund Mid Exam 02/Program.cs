using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Fund_Mid_Exam_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parts = Console
                .ReadLine()
                .Split("|")
                .ToList();

            string input = string.Empty;

            while (input != "Done")
            {
                input = Console.ReadLine();

                string[] command = input.Split();

                switch (command[0])
                {
                    case "Move":
                        
                        parts = MoveLeftOrRight(parts, command);

                        break;
                    case "Check":

                        PrintEvenOrOddIndexesFromList(parts, command);

                        break;

                    default:
                        break;
                }
            }

            string weapon = string.Join("", parts);

            Console.WriteLine($"You crafted {weapon}!");
        }

        static void PrintEvenOrOddIndexesFromList(List<string> toPrint, string[] command)
        {
            List<string> evenOrOdd = new List<string>();

            if (command[1] == "Even")
            {
                for (int i = 0; i < toPrint.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenOrOdd.Add(toPrint[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < toPrint.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        evenOrOdd.Add(toPrint[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", evenOrOdd));
        }    
        static List<string> MoveLeftOrRight(List<string> toMove, string[] command)
        {
            if (command[1] == "Left")
            {
                return MoveLeft(toMove, command);
            }
            else
            {
                return MoveRight(toMove, command);
            }
        }
        static List<string> MoveLeft(List<string> toMove, string[] command)
        {
            int moveIndex = int.Parse(command[2]);
            
            if (moveIndex > 0 && moveIndex <= toMove.Count)
            {
                toMove.Insert(moveIndex - 1, toMove[moveIndex]);

                toMove.RemoveAt(moveIndex + 1);
            }
            return toMove;
        }
        static List<string> MoveRight(List<string> toMove, string[] command)
        {
            int moveIndex = int.Parse(command[2]);

            if (moveIndex >= 0 && moveIndex <= toMove.Count - 2)
            {
                toMove.Insert(moveIndex + 2, toMove[moveIndex]);

                toMove.RemoveAt(moveIndex);
            }

            return toMove;
        }

    }
}

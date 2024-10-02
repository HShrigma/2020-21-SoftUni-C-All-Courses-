using System;
using System.Collections.Generic;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            char[][] beach = new char[r][];

            for (int rows = 0; rows < r; rows++)
            {
                char[] tokenLine = Console.ReadLine().Split().Select(char.Parse).ToArray();

                beach[rows] = tokenLine;
            }


            string input = string.Empty;
            int collected = 0;
            int opponentCollected = 0;

            while ((input = Console.ReadLine()) != "Gong")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                if (row <= beach.Length - 1 && row >= 0)
                {
                    if (col <= beach[row].Length - 1 && col >= 0)
                    {
                        switch (command[0])
                        {
                            case "Find":
                                if (beach[row][col] == 'T')
                                {
                                    collected++;
                                    beach[row][col] = '-';
                                }
                                break;
                            case "Opponent":
                                if (beach[row][col] == 'T')
                                {
                                    opponentCollected++;
                                    beach[row][col] = '-';
                                }

                                string direction = command[3];
                                int move = 4;
                                switch (direction)
                                {
                                    case "up":
                                        for (int i = row; i >= 0 && move > 0; i--)
                                        {
                                            if (col <= beach[i].Length - 1)
                                            {
                                                if (beach[i][col] == 'T')
                                                {
                                                    opponentCollected++;
                                                    beach[i][col] = '-';
                                                }
                                            }
                                            else
                                            {
                                                break;
                                            }
                                            
                                            move--;
                                        }
                                        break;
                                    case "down":
                                        for (int i = row; i < beach.Length && move > 0; i++)
                                        {
                                            if (col <= beach[i].Length - 1)
                                            {
                                                if (beach[i][col] == 'T')
                                                {
                                                    opponentCollected++;
                                                    beach[i][col] = '-';
                                                }
                                            }
                                            else
                                            {
                                                break;
                                            }

                                            move--;
                                        }
                                        break;
                                    case "left":

                                        for (int i = col; i >= 0 && move > 0; i--)
                                        {
                                            if (beach[row][i] == 'T')
                                            {
                                                opponentCollected++;
                                                beach[row][i] = '-';
                                            }
                                            move--;
                                        }
                                        break;
                                    case "right":
                                        for (int i = col; i < beach[row].Length && move > 0; i++)
                                        {
                                            if (beach[row][i] == 'T')
                                            {
                                                opponentCollected++;
                                                beach[row][i] = '-';
                                            }
                                            move--;
                                        }
                                        break;
                                }
                                break;
                        }

                    }
                }
            }

            foreach (var item in beach)
            {
                Console.WriteLine(string.Join(' ', item));
            }
            Console.WriteLine($"Collected tokens: {collected}");
            Console.WriteLine($"Opponent's tokens: {opponentCollected}");

        }
    }
}

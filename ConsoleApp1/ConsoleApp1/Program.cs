using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Row:");
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] puzzle = MakeVector(row);
            puzzle = PermuteRows(puzzle, 1, 2, 3);
        }

        static int[][] MakeVector(int[] row)
        {
            int[][] puzzle = new int[4][];
            for (int i = 0; i < puzzle.Length; i++)
            {
                puzzle[i] = row;
            }
            return puzzle;
        }

        static int[] PermuteVector(int[] row, int p)
        {
            if (p == 0)
            {
                return row;
            }

            Queue<int> q = new Queue<int>();

            foreach (var item in row)
            {
                q.Enqueue(item);
            }

            if (p > 3)
            {
                p = 3;
            }

            while (p != 0)
            {
                int x = q.Dequeue();
                q.Enqueue(x);
                p--;
            }

            for (int i = 0; i < row.Length; i++)
            {
                row[i] = q.Dequeue();
                Console.WriteLine($"row[{i}] is: {row[i]}");
            }
            return row;
        }

        static int[][] PermuteRows(int[][] puzzle, int x, int y, int z)
        {
            puzzle[0] = PermuteVector(puzzle[0], x);
            puzzle[1] = PermuteVector(puzzle[1], y);
            puzzle[2] = PermuteVector(puzzle[2], z);
            Console.WriteLine(String.Join(" ", puzzle[0]));
            Console.WriteLine(String.Join(" ", puzzle[1]));
            Console.WriteLine(String.Join(" ", puzzle[2]));
            Console.WriteLine(String.Join(" ", puzzle[3]));
            return puzzle;
        }
    }
}

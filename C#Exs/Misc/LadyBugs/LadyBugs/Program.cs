using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            
            bool[] field = new bool[fieldSize];

            int[] firstIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            foreach (var index in firstIndexes)
            {
                if (index < 0 || index >= field.Length)
                {
                    continue;
                }
                field[index] = true;
            }
            
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
               
                string[] parts = line.Split();
                
                int position = int.Parse(parts[0]);
                string direction = parts[1];
                int distance = int.Parse(parts[2]);

                if (position < 0 || 
                    position >= field.Length ||
                    field[position] == false)
                {
                    continue;
                }
                field[position] = false;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += distance;
                    }
                    else
                    {
                        position -= distance;
                    }

                    if (position >= field.Length || position < 0)
                    {
                        break;
                    }

                    if (!field[position])
                    {
                        field[position] = true;
                        break;
                    }
                }
            }
            foreach (var cell in field)
            {
                if (cell)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
        }
    }
}

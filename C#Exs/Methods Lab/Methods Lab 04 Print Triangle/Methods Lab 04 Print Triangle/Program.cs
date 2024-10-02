using System;

namespace Methods_Lab_04_Print_Triangle
{
    class Program
    {
        static void TriangleFirstPart(int printFirstPart)
        {
            for (int i = 1; i <= printFirstPart; i++)
            {
                int[] line = new int[i];

                for (int index = 0; index < i; index++)
                {
                    line[index] = index + 1;
                }
             
                Console.WriteLine(string.Join(" ", line));
            }
        }

        static void TriangleSecondPart(int printSecondPart) 
        {
            for (int i = printSecondPart - 1; i > 0; i--)
            {
                int[] line = new int[i];
        
                for (int index = 0; index < i; index++)
                {
                    line[index] = index + 1;
                }

                Console.WriteLine(string.Join(" ", line));
            }
        }

        static void PrintTriangle(int length)
        {
            TriangleFirstPart(length);
            TriangleSecondPart(length);
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }
    }
}

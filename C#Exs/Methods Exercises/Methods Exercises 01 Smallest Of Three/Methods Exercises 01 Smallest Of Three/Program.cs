using System;

namespace Methods_Exercises_01_Smallest_Of_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());

            int numTwo = int.Parse(Console.ReadLine());
            
            int numThree = int.Parse(Console.ReadLine());

            int result = SmallestOfThree(numOne, numTwo, numThree);
            
            Console.WriteLine(result);
        }

        static int SmallestOfThree(int x, int y, int z)
        {
            int[] checkNum = new int[3] { x, y, z };
            
            int smallest = int.MaxValue;
            
            for (int i = 0; i < checkNum.Length; i++)
            {
                if (checkNum[i] < smallest)
                {
                    smallest = checkNum[i];
                }
            }
            
            return smallest;
        }
    }
}

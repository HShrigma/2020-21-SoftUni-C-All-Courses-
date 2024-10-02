using System;

namespace Methods_Exercises_05_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int sumOfTwoMinusThree = SubtractFromSum(SumTwoNums(numOne, numTwo), numThree);
            
            Console.WriteLine(sumOfTwoMinusThree);
        }

        static int SumTwoNums(int x, int y)
        {
            return x + y;
        }

        static int SubtractFromSum(int sum, int subtractor)
        {
            return sum - subtractor;
        }
    }
}

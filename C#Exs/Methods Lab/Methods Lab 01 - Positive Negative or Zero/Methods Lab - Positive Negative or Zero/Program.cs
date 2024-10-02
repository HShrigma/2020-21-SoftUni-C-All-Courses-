using System;

namespace Methods_Lab___Positive_Negative_or_Zero
{
    class Program
    {
        static void NumCheck(int numCheck) 
        {
            if (numCheck == 0)
            {
                Console.WriteLine($"The number {numCheck} is zero.");
            }
            
            else if (numCheck > 0)
            {
                Console.WriteLine($"The number {numCheck} is positive.");
            }
            
            else if (numCheck < 0)
            {
                Console.WriteLine($"The number {numCheck} is negative.");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NumCheck(num);
        }
    }
}

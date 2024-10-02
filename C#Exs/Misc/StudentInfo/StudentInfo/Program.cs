using System;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            int abs = Math.Abs(num);
            Console.WriteLine($"The number is: {abs}");
        }
    }
}

using System;
using System.Linq;

namespace CompareElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstElement = Console.ReadLine().Split().ToArray();
            string[] secondElement = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < secondElement.Length; i++)
            {
                for (int j = 0; j < firstElement.Length; j++)
                {
                    if (secondElement[i] == firstElement[j])
                    {
                        Console.Write(secondElement[i] + " ");
                    }
                }
            }
        }
    }
}
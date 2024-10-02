using System;
using System.Linq;

namespace MergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] left = Console.ReadLine().Split();
            
            string[] right = Console.ReadLine().Split();

            int indexLength = left.Length + right.Length;

            string[] merge = new string[indexLength];

            int counter = 0;

            for (int i = 0; i < left.Length; i++)
            {
                merge[counter] = left[i]; 
                counter++;
            }   
            
            for (int i = 0; i < right.Length; i++)
            {
                merge[counter] = right[i]; 
                counter++;
            }

            Console.WriteLine(string.Join(" ", merge));
        }
    }
}

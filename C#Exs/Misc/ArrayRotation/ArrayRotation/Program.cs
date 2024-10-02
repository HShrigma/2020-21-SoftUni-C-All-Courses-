using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split();
            
            int rotations = int.Parse(Console.ReadLine());

            for (int rots = 0; rots < rotations; rots++)
            {
                string firstElement = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    int previndex = i - 1;
                    arr[previndex] = arr[i];
                }

                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

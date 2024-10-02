using System;
using System.Linq;

namespace deleteDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            
            string uniques = string.Empty;
            
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (!isUnique)
                {
                    arr[i] = " ";
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

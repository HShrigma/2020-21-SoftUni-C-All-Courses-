using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrays = int.Parse(Console.ReadLine());

            int[] prevArr = new int[1] { 1 };

            for (int i = 1; i <= arrays; i++)
            {
                int[] arr = new int[i];
                
                if (i == 1)
                {
                    arr[0] = 1;
                }
                
                else
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        int rightNum = 0;
                        int leftNum = 0;
                        
                        if (j - 1 < 0 && j > prevArr.Length - 1)
                        {
                            arr[j] = 1;
                        }
                        else if (j - 1 < 0 && j <= prevArr.Length - 1)
                        {
                            rightNum = prevArr[j];
                        }
                        else if (j - 1 >= 0 && j > prevArr.Length - 1)
                        {
                            leftNum = prevArr[j - 1];
                        }
                        else if (j - 1 >= 0 && j <= prevArr.Length - 1)
                        {
                            leftNum = prevArr[j - 1];
                            rightNum = prevArr[j];
                        }

                        arr[j] = leftNum + rightNum;
                    }
                }
                Console.WriteLine(string.Join(" ", arr));
                
                prevArr = arr;
            }
        }
    }
}

using System;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numOne = new int[n];
            int[] numTwo = new int[n];
            bool zigZag = true;
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string num1Text = input.Substring(0, input.IndexOf(" "));
                string num2Text = input.Substring(input.IndexOf(" ") + 1);
                if (zigZag == true)
                {
                    numOne[i] = int.Parse(num1Text);
                    numTwo[i] = int.Parse(num2Text);
                }
                else
                {
                    numOne[i] = int.Parse(num2Text);
                    numTwo[i] = int.Parse(num1Text);
                }
                zigZag = !zigZag;
            }
            foreach (var item in numOne)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in numTwo)
            {
                Console.Write(item + " ");
            }
        }
    }
}

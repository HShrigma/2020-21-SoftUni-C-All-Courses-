using System;
using System.Linq;

namespace Methods_Exercises_09_Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            
            while (input != "END")
            {
                input = Console.ReadLine();
               
                if (input == "END")
                {
                    break;
                }
                
                int num = int.Parse(input);
                bool isPalindrom = CheckIfIntIsPalindrome(num);
                Console.WriteLine(isPalindrom);
            }
        }

        static bool CheckIfIntIsPalindrome(int n)
        {
            bool isPalindrome = false;
            
            int[] nToArray = new int[n.ToString().Length];
            
            int pos = 0;
            
            for (int i = n; i > 0; i/= 10)
            {
                if (i % 10 > 0)
                {
                    nToArray[pos] = i % 10;
                }
             
                pos++;
            }
            
            int numOne = int.Parse(String.Join("", nToArray));
            
            int numTwo = int.Parse(String.Join("", nToArray.Reverse()));
            
            if (numOne == numTwo)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}

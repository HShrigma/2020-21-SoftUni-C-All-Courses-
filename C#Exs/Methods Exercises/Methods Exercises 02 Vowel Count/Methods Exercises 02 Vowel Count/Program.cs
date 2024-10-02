using System;

namespace Methods_Exercises_02_Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int vowelCount = GetVowelCountFromString(word);

            Console.WriteLine(vowelCount);
        }

        static int GetVowelCountFromString(string input)
        {
            int vowelCount = 0;
            
            char[] inputToChar = input.ToCharArray();

            for (int i = 0; i < inputToChar.Length; i++)
            {
                switch (inputToChar[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vowelCount++;
                        break;
                    default:
                        break;
                }
            }
            return vowelCount;
        }
    }
}

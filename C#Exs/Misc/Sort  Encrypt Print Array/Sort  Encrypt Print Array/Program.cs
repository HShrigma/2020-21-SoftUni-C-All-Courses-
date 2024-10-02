using System;
using System.Linq;

namespace Sort__Encrypt_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            
            for (int i = 0; i < names.Length; i++)
            {
                string input = Console.ReadLine();
                names[i] = input;
            }

            int[] toNumEncryptor = new int[n];

            for (int j = 0; j < names.Length; j++)
            {
                int sum = 0;

                char[] namesChar = names[j].ToCharArray();
                foreach (var character in namesChar)
                {
                    int conv = 0;
                    switch (character)
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
                            conv = (int)character;
                            conv *= names[j].Length;
                            sum += conv;
                            break;
                        default:
                            conv = (int)character;
                            conv /= names[j].Length;
                            sum += conv;
                            break;
                    }
                }
                toNumEncryptor[j] = sum;
            }

            Array.Sort(toNumEncryptor);
            foreach (var item in toNumEncryptor)
            {
                Console.WriteLine(item);
            }
        }
    }
}

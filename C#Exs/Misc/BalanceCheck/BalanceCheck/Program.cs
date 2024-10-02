using System;

namespace BalanceCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            bool balanced = false; ;
            string bigString = string.Empty;
            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();
                bigString += input;
            }
            for (int j = 0; j <= bigString.Length; j++)
            {
                char[] define = bigString.ToCharArray();
                char bracketCheck = define[j];
                if (bracketCheck == '(')
                {
                    for (int k = j + 1; k < bigString.Length; k++)
                    {
                        char current = define[k];
                        if (current == '(')
                        {
                            balanced = false;
                            break;
                        }
                        if (current == ')')
                        {
                            balanced = true;
                            break;
                        }
                    }
                }
            }
            if (balanced == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}

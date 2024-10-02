using System;
using System.Linq;

namespace Methods_Exercises_04_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetValidPasswordCheck(input);
        }
        static void GetValidPasswordCheck(string password)
        {
            char[] passwordInCharArray = password.ToCharArray();
            bool isValid = true;

            bool isOfValidLength = GetValidPasswordLengthCheck(passwordInCharArray);
            
            if (isOfValidLength == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            bool validSymbols = GetValidPasswordSymbolsCheck(passwordInCharArray);

            if (validSymbols == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            
            bool validDigitCount = GetValidPasswordDigitCountCheck(passwordInCharArray);
            if (validDigitCount == false)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isValid == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool GetValidPasswordLengthCheck(char[] passwordInCharArray)
        {
            bool isValid = true;
            if (passwordInCharArray.Length < 6 || passwordInCharArray.Length > 10)
            {
                isValid = false;
            }
            return isValid;
        }

        static bool GetValidPasswordSymbolsCheck(char[] passwordInCharArray)
        {
            bool isValid = true;

            for (int i = 0; i < passwordInCharArray.Length; i++)
            {
                int charToASCII = passwordInCharArray[i];
               
                if (charToASCII >= 48 && charToASCII <= 57)
                {
                    continue;
                }
                
                else if (charToASCII >= 65 && charToASCII <= 90)
                {
                    continue;
                }
                
                else if (charToASCII >= 97 && charToASCII <= 122)
                {
                    continue;
                }
                
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        static bool GetValidPasswordDigitCountCheck(char[] passwordInCharArray) 
        {
            bool isValid = true;
            int digitCount = 0;

            for (int i = 0; i < passwordInCharArray.Length; i++)
            {
                int charToASCII = passwordInCharArray[i];
                if (charToASCII >= 48 && charToASCII <= 57)
                {
                    digitCount++;
                }
            }

            if (digitCount < 2)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}

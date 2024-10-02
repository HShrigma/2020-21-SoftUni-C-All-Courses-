using System;

namespace Methods_Lab_09_Greater_of_Two_Values
{
    class Program
    {
        static string VariableCheckForInt(string toReturn, string firstVar, string secondVar)
        {
            int firstVarInt = int.Parse(firstVar);

            int secondVarInt = int.Parse(secondVar);

            if (secondVarInt > firstVarInt)
            {
                toReturn = secondVar;
            }

            else
            {
                toReturn = firstVar;
            }
            return toReturn;
        }

        static string VariableCheckForChar(string toReturn, string firstVar, string secondVar)
        {
            char firstVarChar = char.Parse(firstVar);

            char secondVarChar = char.Parse(secondVar);

            if (secondVarChar > firstVarChar)
            {
                toReturn = secondVar;
            }

            else
            {
                toReturn = firstVar;
            }

            return toReturn;

        }

        static string VariableCheckForString(string toReturn, string firstVar, string secondVar)
        {
            int length = 0;

            if (firstVar.Length >= secondVar.Length)
            {
                length = firstVar.Length;
            }

            else
            {
                length = secondVar.Length;
            }
            char[] first = firstVar.ToCharArray();

            char[] second = secondVar.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                if (first[i] == second[i])
                {
                    continue;
                }

                else if (first[i] > second[i])
                {
                    toReturn = firstVar;
                    break;
                }

                else
                {
                    toReturn = secondVar;
                    break;
                }

            }

            return toReturn;        
        }
        static string GetGreaterVariable(string type, string firstVar, string secondVar)
        {
            string toReturn = string.Empty;

            switch (type)
            {
                case "int":

                    toReturn = VariableCheckForInt(toReturn, firstVar, secondVar);

                    break;

                case "char":
                    
                    toReturn = VariableCheckForChar(toReturn, firstVar, secondVar);
                   
                    break;

                case "string":


                    if (firstVar.Length > secondVar.Length)
                    {
                        toReturn = firstVar;
                    }

                    else if (secondVar.Length > firstVar.Length)
                    {
                        toReturn = secondVar;
                    }

                    else
                    {
                        toReturn = VariableCheckForString(toReturn, firstVar, secondVar);
                    }

                    break;

                default:

                    toReturn = "Invalid variable type!";
                    
                    break;
            }
            return toReturn;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string varOne = Console.ReadLine();
            string varTwo = Console.ReadLine();

            string result = GetGreaterVariable(input, varOne, varTwo);

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;

namespace Methods_Exercises_11_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] inputToArr = input
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (input != "end")
            {
                input = Console.ReadLine();
                
                string[] inputCommand = input.Split();
                
                if (inputCommand[0] == "end")
                {
                    break;
                }

                else
                {
                    switch (inputCommand[0])
                    {
                        case "exchange":
                            if (int.Parse(inputCommand[1]) > inputToArr.Length - 1)
                            {
                                Console.WriteLine("Invalid index");

                                continue;
                            }
                        
                            else if (int.Parse(inputCommand[1]) <= inputToArr.Length - 1)
                            {
                                inputToArr = ExchangeIndexOfIntArr(inputCommand, inputToArr);
                            }
                            break;
            
                        case "max":
                            switch (inputCommand[1]) 
                            {
                                case "even":
                                    PrintMaxEvenIndexOfIntArr(inputToArr);
                                    break;

                                case "odd":
                                    PrintMaxOddIndexOfIntArr(inputToArr);
                                    break;
                            }
                            break;
                        case "min":
                            switch (inputCommand[1])
                            {
                                case "even":
                                    PrintMinEvenIndexOfIntArr(inputToArr);
                                    break;

                                case "odd":
                                    PrintMinOddIndexOfIntArr(inputToArr);
                                    break;
                            }
                            break;
                        case "first":
                            if (int.Parse(inputCommand[1]) > inputToArr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                switch (inputCommand[2])
                                {
                                    case "even":
                                        PrintFirstEvenNumsOfIntArr(inputCommand, inputToArr);
                                        break;
                                    case "odd":
                                        PrintFirstOddNumsOfIntArr(inputCommand, inputToArr);
                                        break;
                                }
                            }
                            break;
                        case "last":
                            if (int.Parse(inputCommand[1]) > inputToArr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                switch (inputCommand[2])
                                {
                                    case "even":
                                        PrintLastEvenNumsOfIntArr(inputCommand, inputToArr);
                                        break;
                                    case "odd":
                                        PrintLastOddNumsOfIntArr(inputCommand, inputToArr);
                                        break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            PrintArrayWithBrackets(inputToArr);
        }

        static int[] ExchangeIndexOfIntArr(string[] inputCommand, int[] toExchange)
        {
            int[] exchanged = new int[toExchange.Length];
            
            int indexOfExchange = int.Parse(inputCommand[1]); //turns string to int, not string to ASCII code!!!

            int firstIndexesOfExchangedFromToExchange = toExchange.Length - (indexOfExchange); //give index for toExchange to loop through
            //give elements value of last elements of toExchange 
            int indexTracker = 0;
            
            for (int i = 0; i < indexOfExchange; i++)
            {
                exchanged[i] = toExchange[firstIndexesOfExchangedFromToExchange];
                
                firstIndexesOfExchangedFromToExchange++;
                
                indexTracker++; //save value of i to use for next loop
            }

            for (int i = 0; i < (toExchange.Length - indexOfExchange); i++)
            {
                exchanged[indexTracker] = toExchange[i];
                indexTracker++;
            }
            return exchanged;
        }

        static void PrintMaxEvenIndexOfIntArr(int[] toPrint) 
        {
            int maxIndex = 0;
            int maxElement = int.MinValue;
            bool isFound = false;

            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] >= maxElement && toPrint[i] % 2 == 0)
                {
                    maxElement = toPrint[i];
                    maxIndex = i;
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintMaxOddIndexOfIntArr(int[] toPrint) 
        {
            int maxIndex = 0;
            int maxElement = int.MinValue;
            bool isFound = false;

            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] >= maxElement && toPrint[i] % 2 != 0)
                {
                    maxElement = toPrint[i];
                    maxIndex = i;
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintMinEvenIndexOfIntArr(int[] toPrint)
        {
            int minIndex = 0;
            int minElement = int.MaxValue;
            bool isFound = false;

            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] <= minElement && toPrint[i] % 2 == 0)
                {
                    minElement = toPrint[i];
                    minIndex = i;
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        
        static void PrintMinOddIndexOfIntArr(int[] toPrint)
        {
            int minIndex = 0;
            int minElement = int.MaxValue;
            bool isFound = false;

            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] <= minElement && toPrint[i] % 2 != 0)
                {
                    minElement = toPrint[i];
                    minIndex = i;
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintArrayWithBrackets(int[] toPrint)
        {
            string inBrackets = string.Empty;

            foreach (var item in toPrint)
            {
                inBrackets += item + ", ";
            }

            if (inBrackets.Length > 2)
            {
                inBrackets = inBrackets.Substring(0, inBrackets.Length - 2);
            }
            
            Console.WriteLine($"[{inBrackets}]");
        }

        static void PrintFirstEvenNumsOfIntArr(string[] inputCommand, int[] toPrint)
        {
            int elementsCount = int.Parse(inputCommand[1]);
            
            int elementsTracker = 0;

            string validElements = string.Empty;

            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] % 2 == 0)
                {
                    validElements += toPrint[i] + ", ";
                    elementsTracker++;
                    if (elementsTracker == elementsCount)
                    {
                        break;
                    }
                }
            }
            if (validElements.Length > 2)
            {
                validElements = validElements.Substring(0, validElements.Length - 2);
            }
            Console.WriteLine($"[{validElements}]");
        }

        static void PrintFirstOddNumsOfIntArr(string[] inputCommand, int[] toPrint)
        {
            int elementsCount = int.Parse(inputCommand[1]);

            int elementsTracker = 0;

            string validElements = string.Empty;

            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] % 2 != 0)
                {
                    validElements += toPrint[i] + ", ";
                    elementsTracker++;
                    if (elementsTracker == elementsCount)
                    {
                        break;
                    }
                }
            }
            if (validElements.Length > 2)
            {
                validElements = validElements.Substring(0, validElements.Length - 2);
            }
            Console.WriteLine($"[{validElements}]");
        }
        static void PrintLastEvenNumsOfIntArr(string[] inputCommand, int[] toPrint)
        {
            int elementsCount = int.Parse(inputCommand[1]);

            int elementsTracker = 0;

            string elements = string.Empty;

            for (int i = toPrint.Length - 1; i >= 0; i--)
            {
                if (toPrint[i] % 2 == 0 && toPrint[i] != 0)
                {
                    elements += toPrint[i] + " ";
                    elementsTracker++;
                    if (elementsTracker >= elementsCount)
                    {
                        break;
                    }
                }
            }
            if (elements.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                elements = elements.Substring(0, elements.Length - 1);
                int[] validArr = elements.Split().Select(int.Parse).ToArray();
                Array.Reverse(validArr);
                PrintArrayWithBrackets(validArr);
            }
        }
        
        static void PrintLastOddNumsOfIntArr(string[] inputCommand, int[] toPrint)
        {
            int elementsCount = int.Parse(inputCommand[1]);

            int elementsTracker = 0;

            string elements = string.Empty;

            for (int i = toPrint.Length - 1; i >= 0; i--)
            {
                if (toPrint[i] % 2 != 0 && toPrint[i] != 0)
                {
                    elements += toPrint[i] + " ";
                    elementsTracker++;
                    if (elementsTracker >= elementsCount)
                    {
                        break;
                    }
                }
            }
            if (elements.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                elements = elements.Substring(0, elements.Length - 1);
                int[] validArr = elements.Split().Select(int.Parse).ToArray();
                Array.Reverse(validArr);
                PrintArrayWithBrackets(validArr);
            }
        }
    }
}

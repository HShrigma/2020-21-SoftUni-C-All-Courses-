using System;

namespace Methods_More_Exercise_01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string dataValue = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    PrintIntTimesTwo(dataValue);
                    break;
                
                case "real":
                    PrintDoubleTimes1Point5(dataValue);
                    break;
                
                case "string":
                    PrintStringWithDollarBrackets(dataValue);
                    break;
                
                default:
                    break;
            }
        }

        static void PrintIntTimesTwo(string value) 
        {
            int toInt = int.Parse(value) * 2;

            Console.WriteLine(toInt);
        }

        static void PrintDoubleTimes1Point5(string value)
        {
            double toDouble = double.Parse(value) * 1.5;
            
            Console.WriteLine($"{toDouble:F2}");
        }

        static void PrintStringWithDollarBrackets(string value)
        {
            Console.WriteLine($"${value}$");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericTuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //input1: {firstName} {lastName} {Address}
            string[] input = ReadStringArray(' ');
            Tuple<string, string> nameAddress = new Tuple<string, string>($"{input[0]} {input[1]}", input[2]);

            Console.WriteLine(nameAddress.ToString());

            //input2: {person} {beerInLitres(int)}
            input = ReadStringArray(' ');
            Tuple<string, int> nameBeer = new Tuple<string, int>(input[0], int.Parse(input[1]));

            Console.WriteLine(nameBeer.ToString());

            //input3
            input = ReadStringArray(' ');
            Tuple<int, double> intAndDouble = new Tuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine(intAndDouble.ToString());
        }

        static string[] ReadStringArray(char separator)
        {
            return Console
                .ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

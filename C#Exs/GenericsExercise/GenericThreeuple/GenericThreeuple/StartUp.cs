using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericThreeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //inputLine1: {fName} {lName} {address} {town(could be multiple)}
            string[] input = ReadStringArray(' ');

            string name = input[0] + " " + input[1];

            string address = input[2];

            string town = string.Empty;

            for (int i = 3; i < input.Length; i++)
            {
                if (i != input.Length - 1)
                    town += input[i] + ' ';
                else
                    town += input[i];
            }

            Threeuple<string, string, string> NameAddressTown = new Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(NameAddressTown.ToString());

            //inputLine2: {name} {litres of beer} {DrunkOrNot}

            input = ReadStringArray(' ');

            name = input[0];
            int litres = int.Parse(input[1]);
            bool drunk = DrunkOrNot(input[2]);

            Threeuple<string, int, bool> NameBeerDrunk = new Threeuple<string, int, bool>(name, litres, drunk);

            Console.WriteLine(NameBeerDrunk.ToString());

            //inputLine3: {name} {cash} {bank}
            input = ReadStringArray(' ');

            name = input[0];
            double cash = double.Parse(input[1]);
            string bank = input[2];
            Threeuple<string, double, string> NameCashBank = new Threeuple<string, double, string>(name, cash, bank);
            Console.WriteLine(NameCashBank.ToString());
        }

        static string[] ReadStringArray(char separator)
        { 
            return Console
                .ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries); 
        }

        static bool DrunkOrNot (string input)
        {
            if (input.ToLower() == "drunk")
                return true;
            return false;
        }
    }
}

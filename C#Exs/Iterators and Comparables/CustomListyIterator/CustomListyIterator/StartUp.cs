using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            ListyIterator<string> listy = null;

            while ((command = Console.ReadLine()) != "END")
            {

                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Create")
                {
                    listy = new ListyIterator<string>(input.Skip(1).ToArray());
                }
                else if (input[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (input[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext);
                }
                else if (input[0] == "Print")
                {
                    try
                    {
                        listy.Print();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else if (input[0] == "PrintAll")
                {
                    listy.PrintAll();
                }
            }
        }
    }
}

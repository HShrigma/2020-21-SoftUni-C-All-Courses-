using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Core.Contracts;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core.Contracts
{
    public class Engine : IEngine
    {
        private const string _suffixForCommand = "Command";
        private ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string result = this.commandInterpreter.Read(input);

                if (result == null)
                {
                    break;
                }

                Console.WriteLine(result);
            }
        }
    }
}

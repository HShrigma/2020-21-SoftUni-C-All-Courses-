using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Contracts
{
    public class CommandInterpreter : ICommandInterpreter
    {
        
        public string Read(string args)
        {
            string[] tokens = args.Split();

            string commandName = tokens[0];
            string[] commandArgs = tokens[1..];

            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(n => n.Name == $"{commandName}Command");
            
            ICommand command = (ICommand)Activator.CreateInstance(type);

            return command.Execute(commandArgs);
        }
    }
}

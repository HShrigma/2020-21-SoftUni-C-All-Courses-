/*You need to implement a filtering module to a party reservation software. First, to the Party Reservation Filter Module (PRFM for short) is passed a list with invitations. Next the PRFM receives a sequence of commands that specify whether you need to add or remove a given filter.
Each PRFM command is in the given format:
"{command;filter type;filter parameter}"
You can receive the following PRFM commands: 
•	"Add filter"
•	"Remove filter"
•	"Print" 
The possible PRFM filter types are: 
•	"Starts with"
•	"Ends with"
•	"Length"
•	"Contains"
All PRFM filter parameters will be a string (or an integer only for the "Length" filter). Each command will be valid e.g. you won’t be asked to remove a non-existent filter. The input will end with a "Print" command, after which you should print all the party-goers that are left after the filtration

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_E11_reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, List<string>> mods = new Dictionary<string, List<string>>();
            List<string> command = new List<string>();
            command.Add(string.Empty);

            while (command[0] != "Print")
            {
                command = Console
                    .ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                switch (command[0])
                {
                    case "Add filter":
                        invitations = AddFilter(mods, invitations, command);
                        break;
                    case "Remove filter":
                        invitations = RemoveFilter(mods, invitations, command);
                        break;
                    default:
                        Console.WriteLine(string.Join(' ', invitations));
                        break;
                }
            }
        }

        static List<string> AddFilter(Dictionary<string,List<string>> saved, List<string> edit, List<string> command)
        {
            switch (command[1])
            {
                case "Starts with":
                    Func<string, bool> start = n => n.StartsWith(command[2]);

                    saved.Add(command[1] + command[2], edit);

                    edit = edit.Where(n => start(n)).ToList();
                    
                    break;
                case "Ends with":
                    Func<string, bool> end = n => n.EndsWith(command[2]);

                    saved.Add(command[1] + command[2], edit);

                    edit = edit.Where(n => end(n)).ToList();

                    break;
                case "Length":
                    Func<string, bool> len = n => n.Length == int.Parse(command[2]);
                    saved.Add(command[1] + command[2], edit);
                    edit = edit.Where(n => len(n)).ToList();
                    break;
                default:
                    break;
            }
            return edit;
        }
        static List<string> RemoveFilter(Dictionary<string, List<string>> saved, List<string> edit, List<string> command)
        {
            edit = saved[command[1] + command[2]];
            return edit;
        }
    }
}

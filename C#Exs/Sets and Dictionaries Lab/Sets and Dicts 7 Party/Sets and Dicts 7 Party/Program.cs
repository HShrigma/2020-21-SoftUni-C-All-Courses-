/* There is a party in SoftUni. Many guests are invited and 
 * there are two types of them: VIP and Regular. 
 * When a guest comes, check if he/she exists in any of the two reservation lists.
 * All reservation numbers will be with the length of 8 chars.
 * All VIP numbers start with a digit.
 * First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
 * "PARTY" – After this command you will begin receiving the reservation numbers of the people, who actually came to the party.
 * "END" –The party is over and you have to stop the program and print the appropriate output.
In the end, print the count of the quests who didn't come to the party and afterwards, print their reservation numbers. the VIP guests must be first.

 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Sets_and_Dicts_7_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vips = new HashSet<string>();
            while (input != "END")
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "END":
                        input = "END";
                        break;
                    case "PARTY":
                        while (input != "END")
                        {
                            input = Console.ReadLine();

                            if (guests.Contains(input))
                            {
                                guests.Remove(input);
                            }
                            if (vips.Contains(input))
                            {
                                vips.Remove(input);
                            }
                        }
                        break;
                    default:

                        if (char.IsDigit(input[0]))
                        {
                            vips.Add(input);
                        }
                        else
                        {
                            guests.Add(input);
                        }
                        break;
                }
            }

            Console.WriteLine(guests.Count + vips.Count);

            foreach (var item in vips)
            {
                Console.WriteLine(item);
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*this program prints out each matching bracket statement of an expression on a new line
*ex: 1 + 2*(30 + 2*((8*9)+(10/5)))
*ex out: 
*(8*9)
*(10/5)
*((8*9)+(10/5))
*(30 + 2*((8*9)+(10/5)))
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_04_Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            string input = Console.ReadLine();
            //create empty int stack to keep track of indexes
            Stack<int> indexes = new Stack<int>();
            //loop through each input char
            for (int i = 0; i < input.Length; i++)
            {
                /*algorithm:
                 *we loop through  each char. 
                 *if char is '(' we store its index.
                 *if char is ')' we look for the last case of a '(' (indexes.Pop();),
                 *then print out a substring of input:
                 *starting from our popped index;
                 *with the length being our 
                 *current index(i), subtracting our start index (to account for previous indexes), 
                 *and adding 1 (because length = index++)
                 */
                switch (input[i])
                {
                    case '(':
                        indexes.Push(i);
                        break;
                    case ')':
                        int index = indexes.Pop();
                        Console.WriteLine(input.Substring(index,(i - index) + 1));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

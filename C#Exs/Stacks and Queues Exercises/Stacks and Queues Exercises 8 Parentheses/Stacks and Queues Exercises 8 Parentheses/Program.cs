/*Given a sequence consisting of parentheses, determine whether the expression is balanced. 
* A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closed parenthesis that occurs after the former. 
* Also, the interval between them must be balanced. You will be given three types of parentheses: (, {, and [.
* {[()]} - This is a balanced parenthesis.
* {[(])} - This is not a balanced parenthesis.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_Exercises_8_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            //algorithm:
            //we'll do it with a queue and stack.
            //we'll feed stack open pars. and queue closed pars. 
            //we'll take input as char arr, start sifting through it as we fill it up.
            //whenever closed par. is inserted we compare it with the last open one.
            //doing this dynamically has its benefit for special cases
            //ex: ([]{})
            //if we did 2 loops, one for input and one for checking - it would say this isn't balanced when it is
            //with dynamic checking we wouldn't have this issue.
            //also if this wasn't about stacks AND queues, I wouldn't even bother doing it with a queue. it's easy enough to just compare input[i] in for loop

            //Set corresponding values by index

            string checkOpen = "([{";
            string checkClosed = ")]}";
            //Get user input
            var input = Console
                .ReadLine();

            //create empty queue and stack
            Stack<char> openPars = new Stack<char>();
            Queue<char> closedPars = new Queue<char>();

            //create output condition with bool
            bool balanced = true;

            //start sifting through input array with for loop

            for (int i = 0; i < input.Length; i++)
            {
                if (checkOpen.Contains(input[i]))
                {
                   openPars.Push(input[i]);
                }
                else
                {
                    closedPars.Enqueue(input[i]);
                    if (openPars.Count == 0)
                    {
                        balanced = false;
                        break;
                    }
                    int open = checkOpen.IndexOf(openPars.Pop());
                    int closed = checkClosed.IndexOf(closedPars.Dequeue());
                    //check open par. type with closed par. type
                    if (open != closed)
                    {
                        balanced = false;
                        break;
                    }
                }   
            }

            //print output based on bool balanced
            if (balanced == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

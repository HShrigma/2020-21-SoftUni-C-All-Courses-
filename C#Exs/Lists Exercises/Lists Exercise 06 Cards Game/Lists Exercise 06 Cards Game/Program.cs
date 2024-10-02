using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise_06_Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneHand = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            List<int> playerTwoHand = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool playerOneWins = false;

            bool playerTwoWins = false;

            for (int i = 0; i < playerOneHand.Count; i++)
            {
                
                if (playerOneHand[i] > playerTwoHand[i])
                {
                    playerOneHand.Add(playerOneHand[0]);
                    playerOneHand.Add(playerTwoHand[0]);
                    playerTwoHand.RemoveAt(0);
                    playerOneHand.RemoveAt(0);
                }
              
                else if (playerOneHand[i] < playerTwoHand[i])
                {
                    playerTwoHand.Add(playerTwoHand[0]);
                    playerTwoHand.Add(playerOneHand[0]);
                    playerOneHand.RemoveAt(0);
                    playerTwoHand.RemoveAt(0);
                }

                else if (playerOneHand[i] == playerTwoHand[i])
                {
                    playerOneHand.RemoveAt(0);
                    playerTwoHand.RemoveAt(0);
                }

                if (playerOneHand.Count == 0)
                {
                    playerTwoWins = true;
                    break;
                }
                if (playerTwoHand.Count == 0)
                {
                    playerOneWins = true;
                    break;
                }

                i = -1;
            }
            
            int winSum = 0;
            
            if (playerOneWins)
            {
                foreach (var item in playerOneHand)
                {
                    winSum += item;
                }

                Console.WriteLine($"First player wins! Sum: {winSum}");
            }
            else
            {
                foreach (var item in playerTwoHand)
                {
                    winSum += item;
                }

                Console.WriteLine($"Second player wins! Sum: {winSum}");
            }


        }
    }
}

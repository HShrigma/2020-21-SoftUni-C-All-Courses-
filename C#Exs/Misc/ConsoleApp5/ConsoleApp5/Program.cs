using System;
using System.Numerics;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger bestSnowBall = int.MinValue;
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQual = int.Parse(Console.ReadLine());
                BigInteger snowballVal = BigInteger.Pow((snowBallSnow/snowBallTime),snowBallQual);
                if (snowballVal > bestSnowBall)
                {
                    bestSnowBall = snowballVal;
                    result = $"{snowBallSnow} : {snowBallTime} = {bestSnowBall} ({snowBallQual})";
                }
            }
            Console.WriteLine(result);
        }
    }
}

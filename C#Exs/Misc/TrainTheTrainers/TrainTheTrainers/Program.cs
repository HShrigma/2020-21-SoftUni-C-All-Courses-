using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juries = int.Parse(Console.ReadLine());
            string input = "";
            double toGlobalAvg = 0;
            double toGlobalAvgCount = 0;
            while (input != "Finish")
            {
                input = Console.ReadLine();
                if(input == "Finish")
                { 
                    break; 
                }
                double toLocalAvg = 0;
                double toLocalAvgCount = Convert.ToDouble(juries);
                for (int i = 1; i <= juries; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    toLocalAvg += grade;
                    toGlobalAvgCount++;
                }
                double localAvg = toLocalAvg / toLocalAvgCount;
                toGlobalAvg += toLocalAvg;
                Console.WriteLine($"{input} - {localAvg:F2}.");
            }
            double globalAvg = toGlobalAvg / toGlobalAvgCount;
            Console.WriteLine($"Student's final assessment is {globalAvg:F2}.");
        }
    }
}

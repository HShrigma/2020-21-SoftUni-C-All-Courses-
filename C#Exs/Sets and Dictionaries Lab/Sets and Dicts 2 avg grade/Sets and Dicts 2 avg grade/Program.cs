/* Write a program, which reads a name of a student and his/her grades N times
 * and adds them to the student record, then prints the student's names 
 * with their grades and their average grade.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dicts_2_avg_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            //get N
            int n = int.Parse(Console.ReadLine());
            //create empty Multi-Dictionary (key - string, value - list<f>)
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            //read input N times
            //input is: "{Name(string)} {grade(double)}"

            for (int i = 0; i < n; i++)
            {
                string[] input = ReadStrArray();
                //if name doesn't exist - add it with empty double list
                //then add the grade
                if (grades.ContainsKey(input[0]) == false)
                {
                    grades.Add(input[0], new List<double>());
                }
                grades[input[0]].Add(double.Parse(input[1]));
            }
            
            //get avg and print result:
            //"{name} -> {grades} (avg: {average})"
            foreach (var item in grades)
            {
                double avg = item.Value.Average();

                Console.Write(item.Key + " -> ");
                foreach (var element in item.Value)
                {
                    Console.Write($"{element:F2} ");
                }
                Console.WriteLine($"(avg: {avg:F2})");
            }
        }

        static string[] ReadStrArray()
        {
            return Console.
                ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

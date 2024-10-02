using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes_Exercise_04_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                
                Student student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Grade = double.Parse(input[2])
                };
                
                students.Add(student);
            }

            students.Sort
                (delegate (Student x, Student y) 
                {
                    return y.Grade.CompareTo(x.Grade);
                });

            foreach (var student in students)
            {
                student.Print();
            }

        }
    }

    class Student
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public double Grade { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}: {Grade:F2}");
        }
    }
}
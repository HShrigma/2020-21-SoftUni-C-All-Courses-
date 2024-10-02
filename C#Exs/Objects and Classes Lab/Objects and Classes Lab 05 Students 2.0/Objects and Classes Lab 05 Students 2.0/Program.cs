using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes_Lab_05_Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = string.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();
                
                if (input == "end")
                {
                    break;
                }

                string[] inputToStudentClass = input.Split();

                Student student = new Student()
                {
                    firstName = inputToStudentClass[0],
                    lastName = inputToStudentClass[1],
                    age = inputToStudentClass[2],
                    hometown = inputToStudentClass[3]
                };
                    students.Add(student);
            }

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].IsUniqe(students, students[i], i) == false)
                {
                    students.RemoveAt(i);
                    i = -1;
                }
            }

            string getTown = Console.ReadLine();

            foreach (var item in students)
            {
                if (item.hometown == getTown)
                {
                    item.OutputInfo();
                }
            }
        }
    }
    public class Student
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string age { get; set; }

        public string hometown { get; set; }

        public bool IsUniqe(List<Student> toCheck, Student person, int index)
        {
            bool isUniqe = true;
            for (int i = index + 1; i < toCheck.Count; i++)
            {
                if (toCheck[i].firstName == person.firstName && toCheck[i].lastName == person.lastName)
                {
                    isUniqe = false;
                }
            }
            
            return isUniqe;
        }

        public void OutputInfo()
        {
            Console.WriteLine($"{firstName} {lastName} is {age} years old.");
        }
    }
}

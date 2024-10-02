using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes_Lab_04_Students1
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
                
                string[] inputToStudentsClass = input.Split();

                Student student = new Student()
                {
                    firstName = inputToStudentsClass[0],
                    lastName = inputToStudentsClass[1],
                    age = inputToStudentsClass[2],
                    hometown = inputToStudentsClass[3]
                };

                students.Add(student);
            }

            string findHometown = Console.ReadLine();

            foreach (var item in students)
            {
                if (item.hometown == findHometown)
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

        public void OutputInfo()
        { 
            Console.WriteLine($"{firstName} {lastName} is {age} years old."); 
        }
    }
}

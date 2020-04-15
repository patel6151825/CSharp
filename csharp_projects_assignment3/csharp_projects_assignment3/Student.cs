using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment3
{
    public class Student
    {
        private int stdId;
        private string stdName;
        List<Student> stdList;

        ArrayList studentsAList = new ArrayList();
        public Student()
        {
            Console.WriteLine("Student class constructor is being called");
        }

        public Student(int stdId,string stdName)
        {
            this.stdId = stdId;
            this.stdName = stdName;
        }

        //method to create List
        public void createStudentList()
        {
            stdList = new List<Student>();
        }

        //method to fill students info
        public void fillStudents(int stdId,string stdName)
        {
            stdList.Add(new Student(stdId,stdName));
            studentsAList.Add(new Student(stdId, stdName));
        }

        //method to print students id and name
        public void printStudents()
        {
            Console.WriteLine("Using List");
            foreach (Student std in stdList)
            {
                Console.WriteLine($"Student Id= {std.stdId}, Student Name= {std.stdName}");
            }

            Console.WriteLine("\nUsing ArrayList");
            foreach (Student s in studentsAList)
            {
                Console.WriteLine($"Student Id= {s.stdId}, Student Name= {s.stdName}");
            }

        }
    }
}

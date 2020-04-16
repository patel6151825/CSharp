using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment4
{
    public class Employee
    {
        private string name;
        private double salary;
        List<Employee> res = new List<Employee>();
        private bool found=false;

        //constructor
        public Employee()
        {
            Console.WriteLine("Employee class constructor");
        }

        //parameterized constructor
        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        //method to find emplyee with salary > 200 K
        public bool findEmployee(List<Employee> listEmployees)
        {
            foreach (Employee emp in listEmployees)
            {
                //if salary>200k add to list and make found true
                if (emp.salary > 200000)
                {
                    res.Add(emp);
                    found = true;
                }
            }
            return found;
        }

        //method to print employees result
        public void printResult()
        {
            Console.WriteLine("Employee With Salary Greater than 200k");
            Console.WriteLine("--------------------------------------");
            foreach (Employee e in res)
            {
                Console.WriteLine("Name : " + e.name + ", Salary : " + e.salary);
            }
        }
    }
}

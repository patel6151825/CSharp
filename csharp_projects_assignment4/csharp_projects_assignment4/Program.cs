using System;
using System.IO;
using System.Collections.Generic;

namespace csharp_projects_assignment4
{
    class Program
    {
        public delegate void Print(string sentence);

        public delegate void PrintProduct(int num1,int num2);
        static void Main(string[] args)
        {
            //anonymous method to take a string(sentence)
            Print print = delegate (string sentence)
            {
                //split the sentence using " "--space and store in array of string
                string[] words = sentence.Split(" ");

                Console.WriteLine("After splitting");
                //printing each word on the console
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            };

            //Take string input from user
            Console.Write("Enter sentence : ");
            string str = Console.ReadLine();
            print(str);

            Console.WriteLine("************************************************************\n");
            //anonymous method to take 2 int values
            PrintProduct prod = delegate (int num1, int num2)
            {
                Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
            };

            //Take string input from user
            Console.Write("Enter First Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            prod(n1,n2);

            Console.WriteLine("************************************************************\n");

            //Create a List of Employees
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(new Employee("John", 100000));
            listEmployees.Add(new Employee("Rahul", 300000));
            listEmployees.Add(new Employee("Patel", 200000));
            listEmployees.Add(new Employee("Meera", 400000));
            listEmployees.Add(new Employee("Alice", 500000));
            
            Employee emps = new Employee();

            //Predicate
            Predicate<List<Employee>> empWithHigherSalary = emps.findEmployee;
            bool result = empWithHigherSalary(listEmployees);

            //if emp found call method to print result
            if (result == true)
            {
                emps.printResult();
            }
            else
            {
                Console.WriteLine("No employee with salary > 200k found");
            }
            
            Console.WriteLine("************************************************************\n");
            //Create directory
            string root = @"C:\00_Temp";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            
            string fileName = @"c:\00_Temp\MyTextFile.txt";

            //call to method
            FileWriteAndRead f = new FileWriteAndRead();
            f.writeAndRead(fileName);
            
            Console.WriteLine("************************************************************\n");
            Console.WriteLine("?? Example");
            List<string> names = null;
            string? a = null;
            string? b = "Meera";

            /*
             * Available in C# 8.0 and later, so if old version add <LangVersion>8.0</LangVersion> in .csproj file
             * The null -coalescing assignment operator ??= assigns the value of its right-hand operand to its 
             * left-hand operand only if the left-hand operand evaluates to null. 
             * The ??= operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null
            */
            (names ??= new List<string>()).Add("Paul");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("");
            names.Add(a ??= "John");
            names.Add(b ??= "Bob");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("************************************************************\n");
            Console.WriteLine("Nullable Example"); 
            string? bookName = null;
            double? price = null;

            //Console.WriteLine(price.GetValueOrDefault());
            if (price.HasValue){
                Console.WriteLine("Price is " + price.Value);
            }
            else
            {
                Console.WriteLine("Price is Null");
            }

            string book = bookName ?? "Nimona";
            double value = price ?? 50.55;

            Console.WriteLine("Book : "+book);
            Console.WriteLine("Value : "+value);

            NullableClassEx myClass = new NullableClassEx();

            if (myClass.val == null)
                Console.WriteLine("NullableClass variable is null");

            //Null is considered to be less than any value. So comparison operators won't work against null.
            if (price < value)
            {
                Console.WriteLine("price < value");
            }
            else if (price > value)
            {
                Console.WriteLine("price > value");
            }
            else if (price == value)
            {
                Console.WriteLine("price == value");
            }
            else
            { 
                Console.WriteLine("Could not compare price and Value");
            }

            //Nullable static class is a helper class for Nullable types.
            //It provides a compare method to compare nullable types.

            /*
            if (Nullable.Compare<double>(price, value) < 0)
                Console.WriteLine("price < value");
            else if (Nullable.Compare<double>(price, value) > 0)
                Console.WriteLine("price > value");
            else
                Console.WriteLine("price = value");
            */
        }
    }
}

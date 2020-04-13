using System;

namespace csharp_projects_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new
            {
                color = "red",
                size = "small",
                model = "linear"
            };

            //Call By Value Example
            Console.WriteLine("----------> Call By Value Example");
            int value = 10;
            Console.WriteLine($"value before call is {value}");
            increment(value);
            Console.WriteLine($"value after call is {value}");

            //Call By Reference Example
            Console.WriteLine("\n----------> Call By Reference Example");
            CallBy reference = new CallBy();
            reference.value = 1000;
            Console.WriteLine($"value before call is {reference.value}");
            incrementByReference(reference);
            Console.WriteLine($"value after call is {reference.value}\n");

            IPrint print = new Print();
            //Method to take 3 arguments and print them by using interpolation
            Console.WriteLine("----------> Interpolation");
            print.printArguments("C#", "C# 8", 2019);

            // Method to calculate how many hours we have until next year
            Console.WriteLine("----------> Calculating number of hours till next year");
            print.calculateHours(2021);

            //Using multiline example
            string firstName = "Payal";
            string lastName = "Patel";
            string email = "6151825@johnabbottcollege.net";
            //multiline
            string multiLine = $@"My first name is {firstName},
                                  My last name is {lastName}, and 
                                  My email is {email}\n";
            Console.WriteLine("----------> Printing My Info using multiline");
            Console.WriteLine(multiLine);

            //concatenation --> Name and Email in one string"
            Console.WriteLine("\n----------> Concatenation");
            string fullInfo = "My name is " + firstName + " " + lastName + " and Email is " + email;
            Console.WriteLine(fullInfo);

            //method to show difference between var and dynamic 
            print.showDifference();

            //printing shape annonymous type using interpolation
            printShape(shape);
        }
        /// <summary>
        /// method to increment value by using call by value
        /// </summary>
        /// <param name="value">{int} value</param>
        private static void increment(int value)
        {
            value += 1;
            Console.WriteLine($"value in the  call is {value}");
        }

        /// <summary>
        /// method to increment value by using call by reference
        /// </summary>
        /// <param name="reference">{class} CallBy</param>
        private static void incrementByReference(CallBy reference)
        {
            reference.value += 1;
        }

        /// <summary>
        /// method for Printing shape annonymus type using interpolation
        /// </summary>
        /// <param name="shape">{annonymus} shape</param>
        private static void printShape(dynamic shape)
        {
            Console.WriteLine("\n----------> Printing shape annonymus type using interpolation");
            Console.WriteLine($"Shape has color: {shape.color}, size: {shape.size} and model: {shape.model}\n");
        }

    }
}

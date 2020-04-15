using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp_projects_assignment3
{
    class Program
    {
        //Delagate
        public delegate void Rect(double length, double width);

        static void Main(string[] args)
        {
            Student std = new Student();
            //creating student list
            std.createStudentList();

            //call to a method for filling value in to list
            std.fillStudents(101, "John");
            std.fillStudents(102, "Paul");
            std.fillStudents(103, "Alice");
            std.fillStudents(104, "Bob");
            std.fillStudents(105, "Karan");

            //call to a method for printing students
            std.printStudents();

            Console.WriteLine("\n*****************************************************");
            Console.WriteLine("\nUsing Generic Class");
            // Using the generic type with an string type parameter
            MyGenericClass<int> param1 = new MyGenericClass<int>(25);
            param1.genericPrintMethod();

            // Using the generic type with an int type parameter
            MyGenericClass<string> param2 = new MyGenericClass<string>("csharp");
            param2.genericPrintMethod();

            Console.WriteLine("\n*****************************************************");
            Console.WriteLine("\nUsing Hashtable");
            Hashtable ht = new Hashtable()
            {
                {1, "csharp" },
                {2, "java" },
                {3, "python"},
                {4, "PHP" },
                {5, "javascript" }
            };

            //Iterate through the hashtable items and printing them
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("key:{0} , value:{1}", item.Key, item.Value);
            }

            Console.WriteLine("\n*****************************************************");
            //Call By Value & Reference
            CallByValueAndRef callBy = new CallByValueAndRef();

            Console.WriteLine("\nCall By Value Example");
            int value1 = 10;
            Console.WriteLine("value before calling the function= " + value1);
            callBy.doubleValue(value1);
            Console.WriteLine("value after calling the function for double it= " + value1);

            Console.WriteLine("\nCall By Reference Example");
            int value2 = 50;
            Console.WriteLine("value before calling the function= " + value2);
            callBy.halfValue(ref value2);
            Console.WriteLine("value after calling the function for makeing it half= " + value2);

            Console.WriteLine("\n*****************************************************");
            //Delagate Example
            Console.WriteLine("\nUsing Delagates");
            DelegateClass dc = new DelegateClass();

            //Asking user for rectanle lengtha nd width
            Console.Write("Enter Length of Rectangle = ");
            double l = Double.Parse(Console.ReadLine());
            Console.Write("Enter Width of Rectangle = ");
            double w = Double.Parse(Console.ReadLine());
            Rect area = dc.calculateArea;
            area(l, w);

            Rect circumference = dc.calculateCircumference;
            circumference(l, w);

            Rect biggestSide = dc.findBiggestSide;
            biggestSide(l, w);
        }
    }
}

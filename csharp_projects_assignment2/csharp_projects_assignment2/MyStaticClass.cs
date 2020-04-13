using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment2
{
    class MyStaticClass
    {
        //static field
        public static double pi = 3.14;
        public static int radius = 0;
        public static double area = 0;
        static MyStaticClass()
        {
            Console.WriteLine("\nStatic Class Constructor is being called");
        }

        //static method to calculate Area
        public static void calculateArea()
        {
            area = pi * radius * radius;
            Console.WriteLine($"Area of circle with radius {radius} is {Math.Round(area,2)}");
        }
    }
}

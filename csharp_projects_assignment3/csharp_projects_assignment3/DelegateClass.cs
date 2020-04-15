using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment3
{
    class DelegateClass
    {
        /// Method to calculate area of rectangle
        /// <param name="length">{double} length of rectabgle</param>
        /// <param name="width"> {double} width of rectangle</param>
        public void calculateArea(double length, double width)
        {
            double area = length * width;
            printResult("Area", area);
        }

        /// Method to calculate circumference of rectangle
        /// <param name="length">{double} length of rectabgle</param>
        /// <param name="width"> {double} width of rectangle</param>
        public void calculateCircumference(double length, double width)
        {
            double cir = 2 * (length + width);
            printResult("Circumference", cir);
        }

        /// Method to find the biggest side of rectangle
        /// <param name="length">{double} length of rectabgle</param>
        /// <param name="width"> {double} width of rectangle</param>
        public void findBiggestSide(double length, double width)
        {
            double ans=length;
            if (length < width)
            {
                ans = width;
            }
            printResult("Biggest side", ans);
        }

        //method for printing result
        public void printResult(string op,double res)
        {
            Console.WriteLine("\n"+op+ " of rectangle is " + Math.Round(res,2));
        }
        
    }
}

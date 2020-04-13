using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment1
{
    class Print : IPrint
    {
        /// <summary>
        /// Method to show usage of interpolation
        /// </summary>
        /// <param name="language">{string} language</param>
        /// <param name="version"> {string} version</param>
        /// <param name="year">    {int}    year</param>
        public void printArguments(string language, string version, int year)
        {
            Console.WriteLine($"{language}'s latest version is {version} and was released in {year}\n");
        }
        
        /// <summary>
        /// method to calculate number of hours left till next year
        /// </summary>
        /// <param name="year">{int} year </param>
        public void calculateHours(int year)
        {
            //setting time for next year and today
            DateTime nextYear = new DateTime(year, 1, 1, 0, 0, 0);
            DateTime today = DateTime.Now;

            //performing subtraction
            TimeSpan ts = nextYear - today;

            //calculating number of hours
            var hours = (ts.Days * 24) + ts.Hours;

            Console.WriteLine($"{hours} hours we have until next year\n");
        }

        /// <summary>
        /// method to show diffrence between var and dynamic
        /// </summary>
        public void showDifference()
        {
            //Using var keyword for creating and initializing static type variable i.e. compile time
            //If not assigned at compile time compiler will throw error
            Console.WriteLine("\n---------->Using var");
            var bookName = "Nimona";
            var category = 'H';
            var price = 135.67d;
            var sold = false;
            var availableBooks = 125;

            // Displaying the type 
            Console.WriteLine("Type of 'bookName' is : {0} ", bookName.GetType());
            Console.WriteLine("Type of 'category' is : {0} ", category.GetType());
            Console.WriteLine("Type of 'price' is : {0} ", price.GetType());
            Console.WriteLine("Type of 'sold' is : {0} ", sold.GetType());
            Console.WriteLine("Type of 'availableBooks' is : {0} ", availableBooks.GetType());

            //Using dynamic keyword for creating dynamic type variable,
            //type is not checked at compile time instead type is assigned at runtime

            Console.WriteLine("\n---------->Using dynamic");
            dynamic carName = "Honda";
            dynamic year = 2019;
            dynamic carPrice = 50500.99;
            dynamic model = "Civic";

            // Getting the actual type of dynamic variables Using GetType() method 
            Console.WriteLine("Get the actual type of 'carName: {0}", carName.GetType().ToString());
            Console.WriteLine("Get the actual type of 'year': {0}", year.GetType().ToString());
            Console.WriteLine("Get the actual type of 'carPrice': {0}", carPrice.GetType().ToString());
            Console.WriteLine("Get the actual type of 'model': {0}", model.GetType().ToString());
        }
    }
}

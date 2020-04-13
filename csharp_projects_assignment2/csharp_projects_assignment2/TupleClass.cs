using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment2
{
    class TupleClass
    {
        public TupleClass()
        {
            Console.WriteLine("\nTuple class constructor is being called");
        }
        /// <summary>
        ///  A method that takes tuple as an input, print it and returns tuple as the output
        /// </summary>
        /// <param name="book">{Tuple} book Information</param>
        ///                    {int}   book id
        ///                    {string}book name
        ///                    {int}   author id
        ///                    {int}   year
        /// <returns>{Tuple} More info about book</returns>
        public Tuple<int, string, bool> displayAndCreate(Tuple<int, string, int, int> book)
        {
            Console.WriteLine("Tuple class method is being called");
            Console.WriteLine($"Id : {book.Item1}");
            Console.WriteLine($"Name : {book.Item2}");
            Console.WriteLine($"Year : {book.Item4}");
            return Tuple.Create(book.Item3,"Paul",true);
        }
    }
}

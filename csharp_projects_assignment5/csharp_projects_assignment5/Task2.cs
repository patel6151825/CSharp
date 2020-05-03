using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_projects_assignment5
{
    class Task2
    {
        public void displayTopNthRecords(List<int> list, int noOfRecords)
        {
            //sort the list in asc order
            list.Sort();

            //reversing the list so that get top numbers first
            list.Reverse();

            if (noOfRecords>0)
            {
                Console.Write($"The top {noOfRecords} records from the list are :");
                for (int i = 0; i < noOfRecords; i++)
                {
                    Console.Write(list[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("You asked for invalid records");
            }
            
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_projects_assignment5
{
    class Task1
    {
        public void countNumberAndFrequencey(int[] arr)
        {
            var count = from n in arr
                        group n by n into m
                        select m;
            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var number in count)
            {
                Console.WriteLine("Number " + number.Key + " appears " + number.Count() + " times");
            }
        }
    }
}

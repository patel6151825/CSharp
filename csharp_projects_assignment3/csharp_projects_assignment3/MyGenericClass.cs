using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment3
{
    class MyGenericClass<G>
    {
        //add a generic member
        private G genericMember;

        //generic constructor
        public MyGenericClass(G value)
        {
            genericMember = value;
        }

        //generic method for printing
        public void genericPrintMethod()
        {
            Console.WriteLine($"Value of the parameter= {this.genericMember}");
        }
    }
}

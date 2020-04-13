using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment1
{
    interface IPrint
    {
        void printArguments(string language,string version,int year);

        void calculateHours(int year);

        void showDifference();
    }
}

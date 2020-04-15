using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment3
{
    class CallByValueAndRef
    {
        //method to double the value which is passed as parameter
        public void doubleValue(int value)
        {
            value *= 2;
        }

        //method to half the value which is passed as ref parameter
        public void halfValue(ref int value)
        {
            value /= 2;
        }
    }
}

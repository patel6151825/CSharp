using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment2
{
    class IndexerClass
    {
        // class data member 
        private string[] val = new string[3];

        // Indexer declaration  
        public string this[int index]
        {
            // get Accessor for retrieving the values stored in val[] array of strings 
            get
            {
                if (index < 0 && index >= val.Length)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                return val[index];
            }

            // set Accessor for setting the value at passed index of val 
            set
            {
                if (index < 0 && index >= val.Length)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                val[index] = value;
            }
        }
    }
}

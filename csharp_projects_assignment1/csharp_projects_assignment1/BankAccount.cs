using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_projects_assignment1
{
    struct BankAccount
    {
        enum TypeOfAccount
        {
            Checking = 0,
            Saving = 1,
            LineOfCredit = 2
        }
        public float depositAmount { get; set; }
    }
}

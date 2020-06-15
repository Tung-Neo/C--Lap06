using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_12
{
    class EmployeeDetails
    {
        public string[] empName = new String[2];
        public string this [int index]
        {
            get
            {
                return empName[index];
            }
            set
            {
                empName[index] = value;
            }
        }
    }
}

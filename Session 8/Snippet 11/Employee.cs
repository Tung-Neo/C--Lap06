using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_11
{
    interface ISet
    {
        void AcceptDetails(int val1, string val2);
    }
    interface IGet
    {
        void Display();
    }
    class Employee : ISet
    {
        int empID;
        string empName;
        public void AcceptDetails(int val1, string val2)
        {
            empID = val1;
            empName = val2;
        }
    }
}

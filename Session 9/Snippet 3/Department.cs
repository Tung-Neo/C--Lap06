using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_3
{
    class Department
    {
        string deptName;
        int deptID;
        public string DeptName
        {
            set
            {
                deptName = value;
            }
        }
        public int DeptID
        {
            set
            {
                deptID = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Department Name: " + deptName);
            Console.WriteLine("Department ID: " + deptID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_7
{
    class Employee
    {
        string empName;
        int empID;
        float salary;
        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }
        public int EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }
        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if(value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }
    }
    class SalaryDetails : Employee
    {
        static void Main(string[] args)
        {
            SalaryDetails objSalary = new SalaryDetails();
            objSalary.EmpName = "Frank";
            objSalary.EmpID = 10;
            objSalary.Salary = 1000.25F;
            Console.WriteLine("Name: " + objSalary.EmpName);
            Console.WriteLine("ID: " + objSalary.EmpID);
            Console.WriteLine("Salary: " + objSalary.Salary + "$");
        }
    }
}

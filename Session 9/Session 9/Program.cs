using System;

namespace Session_9
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryDetails objSal = new SalaryDetails();
            objSal.EmployeeName = "Patrick Johnson";
            Console.WriteLine("Employee Name: " + objSal.EmployeeName);
        }
    }
}

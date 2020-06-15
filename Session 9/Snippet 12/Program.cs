using System;

namespace Snippet_12
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails objEmp = new EmployeeDetails();
            objEmp[0] = "Jack Anderson";
            objEmp[1] = "Kate Jones";
            Console.WriteLine("Employee Names: ");
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(objEmp[i] + "\t");
            }
        }
    }
}

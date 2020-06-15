using System;

namespace Snippet_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                Name = "John Doe",
                Age = 24,
                Designation = "Sales Person"
            };
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}", emp.Name, emp.Age, emp.Designation);
        }
    }
}

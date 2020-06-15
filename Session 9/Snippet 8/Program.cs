using System;

namespace Snippet_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "John Doe";
            emp.Age = 24;
            emp.Designation = "Sales Person";
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}", emp.Name, emp.Age, emp.Designation);
        }
    }
}

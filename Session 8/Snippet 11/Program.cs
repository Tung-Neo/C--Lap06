using System;

namespace Snippet_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.AcceptDetails(10, "Jack");
            IGet objGet = objEmployee as IGet;
            if(objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }
        }
    }
}

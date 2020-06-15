using System;

namespace Snippet_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Department objDe = new Department();
            objDe.DeptID = 201;
            objDe.DeptName = "Sales";
            objDe.Display();
        }
    }
}

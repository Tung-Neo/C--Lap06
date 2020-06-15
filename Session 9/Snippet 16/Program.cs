using System;

namespace Snippet_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Students objStu = new Students();
            objStu[0] = "James";
            objStu[1] = "Willson";
            objStu[2] = "Patrick";
            Console.WriteLine("Student Names");
            Console.WriteLine();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(objStu[i]);
            }
        }
    }
}

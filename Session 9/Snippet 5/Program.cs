using System;

namespace Snippet_5
{
    class Program
    {
        static void Main(string [] args)
        {
            University.UniversityName = "University of Maryland";
            University.Department = "Physics";
            Console.WriteLine("University Name: " + University.UniversityName);
            Console.WriteLine("Department Name: " + University.Department);
        }
    }
}

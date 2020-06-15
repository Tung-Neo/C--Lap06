using System;

namespace Snippet_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Resutl objResult = new Resutl();
            objResult[0] = "First";
            objResult[1] = "Pass";
            Student objStudent = new Student();
            objStudent[0] = "Peter";
            objStudent[1] = "Patrick";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(objStudent[i] + "\t\t" + objResult[i] + " class");
            }
        }
    }
}

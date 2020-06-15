using System;

namespace Snippet_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount objAcount = new Acount();
            string[] id = new string[3] { "1001", "1002", "1003" };
            string[] name = new string[3] { "John", "Peter", "Patrick" };
            int counter = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 1; j++)
                {
                    objAcount[i, j] = id[counter];
                    objAcount[i, j + 1] = name[counter++];
                }
            }
            Console.WriteLine("ID Name");
            Console.WriteLine();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine(objAcount[i, j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
